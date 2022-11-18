using _3dhi.Data;

namespace _3dhi.Services.PricingService
{
    public class PricingService : IPricingService
    {
        private readonly ApplicationDbContext _db;
        public PricingService(ApplicationDbContext db)
        {
            _db = db;
        }
        // Create Pricing
        // Get Pricing
        // Edit Pricing
    }
}
