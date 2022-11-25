using _3dhi.Data;
using _3dhi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace _3dhi.Services.AdminsitrationService
{
    public class AdministrationService : IAdministrationService
    {
        private readonly ApplicationDbContext _db;

        public AdministrationService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<User>> GetAllAdmins()
        {







            var admins = await this._db.Users
                 .Include(x => x.User)
                 .ThenInclude(y => y.Role)
                 .Where(x => x.UserRoles.RoleId))                               
                 .ToListAsync();

            return admins;

        }
    }
}
