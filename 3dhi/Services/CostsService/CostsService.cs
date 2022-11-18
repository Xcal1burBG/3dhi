using _3dhi.Data;

namespace _3dhi.Services.AdditionalService
{
    public class CostsService : ICostsService
    {
        private readonly ApplicationDbContext _db;
        public CostsService(ApplicationDbContext db)
        {
            _db = db;
        }
        // Create Cost
        // Get Cost
        // Edit Cost
        // Delete Cost
    }
}
