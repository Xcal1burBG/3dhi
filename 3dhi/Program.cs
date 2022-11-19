using _3dhi.Data;
using _3dhi.Data.AdminSeeder;
using _3dhi.Data.Entities;
using _3dhi.Services.AdditionalService;
using _3dhi.Services.IncomesService;
using _3dhi.Services.ListingsService;
using _3dhi.Services.MessagesService;
using _3dhi.Services.OccupancyService;
using _3dhi.Services.PricingService;
using _3dhi.Services.RealEstatesService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentity<User, Role>(options =>
{
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultUI().AddDefaultTokenProviders();
//builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false)
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//            .AddDefaultUI()
//            .AddDefaultTokenProviders();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.Configure<IdentityOptions>(options =>
{
    // Default Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
});
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddTransient<IListingsService, ListingsService>();
builder.Services.AddTransient<IMessagesService, MessagesService>();
builder.Services.AddTransient<IOccupancyService, OccupancyService>();
builder.Services.AddTransient<IPricingService, PricingService>();
builder.Services.AddTransient<IRealEstatesService, RealEstatesService>();
builder.Services.AddTransient<ICostsService, CostsService>();
builder.Services.AddTransient<IIncomesService, IncomesService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

// Seed Admin in Database
AdminSeeder.Seed(app);

app.Run();
