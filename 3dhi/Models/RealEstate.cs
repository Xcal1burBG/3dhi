using Humanizer;

namespace _3dhi.Models
{
    public class RealEstate
    {
        public int Id { get; set; }
        public Guid OwnerUserId { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public int FloorNumber { get; set; }
        public decimal Price { get; set; }
        public ICollection<PhotoPath> PhotoPaths { get; set; }
    }
}
