using _3dhi.Data;

namespace _3dhi.Services.OccupancyService
{
    public class OccupancyService : IOccupancyService
    {
        private readonly ApplicationDbContext _db;
        public OccupancyService(ApplicationDbContext db)
        {
            _db = db;
        }
        // Create Occupancy
        // Get Occupancy
        // Edit Occupancy
        // Delete Occupancy
        // Block Dates
    }
}
