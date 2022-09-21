using Humanizer;

namespace _3dhi.Data.Entities
{
    public sealed class PhotoPath
    {
        public Guid Id { get; set; }
        public Guid ListingId { get; set; }
        public string Path { get; set; }
        public DateTime DateSaved { get; set; }
        public int SizeKb { get; set; }
        public Listing Listing { get; set; }
    }
}
