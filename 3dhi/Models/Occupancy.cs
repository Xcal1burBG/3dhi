namespace _3dhi.Models
{
    public sealed class Occupancy
    {
        public Guid ListingId { get; set; }
        public DateTime Date { get; set; }
        public bool IsAvailable { get; set; }
    }
}
