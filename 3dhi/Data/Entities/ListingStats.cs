namespace _3dhi.Data.Entities
{
    public sealed class ListingStats
    {
        public Guid ListingId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Income { get; set; }
        public decimal Cost { get; set; }
    }
}
