using _3dhi.Data.Entities;
using _3dhi.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
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


                    admin.Id = Guid.NewGuid();
                    admin.UserName = "admin@admin.com";
                    admin.NormalizedUserName = "ADMIN@ADMIN.COM";
                    admin.Email = "admin@admin.com"; 
                    admin.NormalizedEmail = "ADMIN@ADMIN.COM";
                    admin.EmailConfirmed = true;
                    admin.PasswordHash = hasher.HashPassword(admin, "admin85");
                    admin.SecurityStamp = Guid.NewGuid().ToString();
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

                    // Creating Role "Admin"

                    var role = new Role();

                    role.Id = Guid.NewGuid();
                    role.Name = "Admin";
                    role.NormalizedName = "ADMIN";

                    context.Roles.Add(role);
                    context.SaveChanges();


                    var userRole = new UserRole
                    {
                        UserId = admin.Id,
                        RoleId = role.Id
                    };

                    context.UserRoles.Add(userRole);


                    context.SaveChanges();

                }

            }

        }
    }
}
