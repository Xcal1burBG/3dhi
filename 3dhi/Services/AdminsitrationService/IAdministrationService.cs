using _3dhi.Data.Entities;

namespace _3dhi.Services.AdminsitrationService
{
    public interface IAdministrationService
    {
        public Task<List<User>> GetAllAdmins();
    }
}
