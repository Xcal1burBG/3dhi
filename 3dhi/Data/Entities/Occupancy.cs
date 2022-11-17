using _3dhi.Enum;

namespace _3dhi.Data.Entities
{
    public class Occupancy
    {
        public Guid Id { get; set; }
        public Guid ListingId { get; set; }
        public DateTime Date { get; set; }
        public bool IsAvailable { get; set; }
        public EntityStatus EntityStatus { get; set; }
    }
}
