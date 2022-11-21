//using _3dhi.Data.Entities;
//using _3dhi.Enum;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
//using Microsoft.EntityFrameworkCore;
//using System.Security;

//namespace _3dhi.Data.AdminSeeder
//{
//    public class AdminSeeder
//    {
//        private readonly ApplicationDbContext _db;

//        public AdminSeeder(ApplicationDbContext db)
//        {
//            _db = db;
//        }
//        public void Seed(IApplicationBuilder applicationBuilder)
//        {



//            //this._db.Database.EnsureCreated();

//            if (!_db.Users.Any())
//            {
//                //Adding User "Admin"
//                var hasher = new PasswordHasher<User>();
//                var admin = new User();


//                admin.Id = Guid.NewGuid();
//                admin.UserName = "admin@admin.com";
//                admin.NormalizedUserName = "ADMIN@ADMIN.COM";
//                admin.Email = "admin@admin.com";
//                admin.NormalizedEmail = "ADMIN@ADMIN.COM";
//                admin.EmailConfirmed = true;
//                admin.PasswordHash = hasher.HashPassword(admin, "admin85");
//                admin.SecurityStamp = Guid.NewGuid().ToString();
//                admin.PhoneNumberConfirmed = true;
//                admin.TwoFactorEnabled = false;
//                admin.LockoutEnabled = true;
//                admin.AccessFailedCount = 5;
//                admin.FirstName = "Admin";
//                admin.Surname = "Admin";
//                admin.DateCreated = DateTime.UtcNow;
//                admin.IsHost = false;
//                admin.EntityStatus = EntityStatus.Created;

//                _db.Users.Add(admin);
//                _db.SaveChanges();

//                // Creating Role "Admin"

//                var role = new Role
//                {
//                    Id = Guid.NewGuid(),
//                    Name = "Admin",
//                    NormalizedName = "ADMIN",
//                    //Discriminator = "ApplicationUser"


//                };

//                _db.Roles.Add(role);
//                _db.SaveChanges();

//                var userRole = new UserRole
//                {
//                    UserId = admin.Id,
//                    RoleId = role.Id
//                };

//                _db.UserRoles.Add(userRole);


//                _db.SaveChanges();



//            }

//        }
//    }
//}
