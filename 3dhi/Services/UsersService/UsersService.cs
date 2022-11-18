using _3dhi.Data;

namespace _3dhi.Services.UsersService
{
    public class UsersService : IUsersService
    {
        public readonly ApplicationDbContext _db;

        public UsersService(ApplicationDbContext db)
        {
            _db = db;

        }

        //public async Task<User> GetListOfAllAdmins()
        //{
        //    var admins = await this._db.Users

        //}

    }
}
