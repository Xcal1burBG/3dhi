using _3dhi.Data.Entities;
using _3dhi.Data.Entities._3dhi.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;

namespace _3dhi.Data
{
    public class ApplicationDbContext : IdentityDbContext <IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=3hdi;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<string>().HaveColumnType("nvarchar(200)");
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<decimal>().HavePrecision(10, 2);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser<Guid>>(entity => { entity.ToTable(name: "Users").Property(x => x.Id).HasColumnType("uniqueidentifier"); });
            modelBuilder.Entity<IdentityRole<Guid>>(entity => { entity.ToTable(name: "Roles").Property(x => x.Id).HasColumnType("uniqueidentifier"); });
            modelBuilder.Entity<IdentityUserRole<Guid>>(entity => { entity.ToTable("UserRoles"); });
            modelBuilder.Entity<IdentityUserClaim<Guid>>(entity => { entity.ToTable("UserClaims").Property(x => x.UserId).HasColumnType("uniqueidentifier"); });
            modelBuilder.Entity<IdentityUserLogin<Guid>>(entity => { entity.ToTable("UserLogins").Property(x => x.UserId).HasColumnType("uniqueidentifier"); ; });
            modelBuilder.Entity<IdentityUserLogin<Guid>>(entity => { entity.ToTable("UserLogins").HasKey(key => new { key.ProviderKey, key.LoginProvider }); });
            modelBuilder.Entity<IdentityRoleClaim<Guid>>(entity => { entity.ToTable("RoleClaims"); });
            modelBuilder.Entity<IdentityUserToken<Guid>>(entity => { entity.ToTable("UserTokens").HasKey(key => new { key.UserId, key.LoginProvider, key.Name }); });



                        
            modelBuilder.Entity<Pricing>().Property(x => x.Price).HasPrecision(6, 2);
            modelBuilder.Entity<Listing>().Property(x => x.Description).HasColumnType("nvarchar(1000)");
            modelBuilder.Entity<Listing>().Property(x => x.Description).HasColumnType("nvarchar(1000)");
            modelBuilder.Entity<Listing>().HasOne(x => x.User).WithMany(y => y.Listings).HasForeignKey("FK_Listing_UserId");
            //modelBuilder.Entity<UserRole>().HasOne(x => x.User).WithMany(y => y.UserRoles).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<UserRole>().HasOne(x => x.Role).WithMany(y => y.UserRoles).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Message>().HasNoKey();
            modelBuilder.Entity<Occupancy>().HasNoKey();
            modelBuilder.Entity<Pricing>().HasNoKey();
            modelBuilder.Entity<Cost>().HasNoKey();
            modelBuilder.Entity<Income>().HasNoKey();

        }

        public virtual DbSet<Listing> Listings { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Occupancy> Occupancies { get; set; }
        public virtual DbSet<PhotoPath> PhotoPaths { get; set; }
        public virtual DbSet<Pricing> Pricing { get; set; }
        public virtual DbSet<RealEstate> RealEstates { get; set; }
        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        //public override DbSet<User> Users { get; set; }
        //public override DbSet<Role> Roles { get; set; }
        //public virtual DbSet<UserRole> UserRoles { get; set; }

          
       
    }
}

