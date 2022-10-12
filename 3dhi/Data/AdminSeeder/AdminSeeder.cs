using _3dhi.Data.Entities;
using _3dhi.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security;

namespace _3dhi.Data.AdminSeeder
{
    public class AdminSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if (!context.Users.Any())
                {
                    //Adding User "Admin"
                    var hasher = new PasswordHasher<User>();
                    var admin = new User();


                    admin.Id = new Guid();
                    admin.UserName = "Admin";
                    admin.NormalizedUserName = "ADMIN";
                    admin.Email = "admin@admin.com";
                    admin.NormalizedEmail = "ADMIN@ADMIN.COM";
                    admin.EmailConfirmed = true;
                    admin.PasswordHash = hasher.HashPassword(admin, "admin85");
                    admin.PhoneNumberConfirmed = true;
                    admin.TwoFactorEnabled = false;
                    admin.LockoutEnabled = true;
                    admin.AccessFailedCount = 5;
                    admin.FirstName = "Admin";
                    admin.Surname = "Admin";
                    admin.DateCreated = DateTime.UtcNow;
                    admin.IsHost = false;
                    admin.EntityStatus = EntityStatus.Created;

                    context.Users.Add(admin);
                    context.SaveChanges();
                    
                    // Adding Role "Admin"

                    var role = new Role();

                    role.Id = new Guid();
                    role.Name = "Admin";
                    role.NormalizedName = "ADMIN";

                    context.Roles.Add(role);

                    context.SaveChanges();

                    // Creating relation between role and user "Admin"
                    context.UserRoles.Add(new UserRole()
                    {
                        UserId = admin.Id,
                        RoleId = role.Id
                    });

                    context.SaveChanges();

                }
            }

        }
    }
}
