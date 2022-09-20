namespace _3dhi.Models
{
    public sealed class Pricing
    {
        public Guid ListingId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
