using _3dhi.Enum;

namespace _3dhi.Data.Entities
{
    public class Cost
    {
        public Guid Id { get; set; }
        public Guid ListingId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public EntityStatus EntityStatus { get; set; }
    }
}
