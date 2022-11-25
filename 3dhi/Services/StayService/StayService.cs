using _3dhi.Data;

namespace _3dhi.Services.StayService
{
    public class StayService : IStayService
    {
        private readonly ApplicationDbContext _db;

        public StayService(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
