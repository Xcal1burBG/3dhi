namespace _3dhi.Data.Entities
{
    public class Cost
    {
        public Guid ListingId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
