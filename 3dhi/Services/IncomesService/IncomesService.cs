using _3dhi.Data;

namespace _3dhi.Services.IncomesService
{
    public class IncomesService : IIncomesService
    {
        public readonly ApplicationDbContext _db;

        public IncomesService(ApplicationDbContext db)
        {
            _db = db;
        }

    }
}
