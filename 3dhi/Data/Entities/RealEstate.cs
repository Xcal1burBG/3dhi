using _3dhi.Enum;
using Humanizer;

namespace _3dhi.Data.Entities
{
    public class RealEstate
    {
        public Guid Id { get; set; }
        public string OwnerName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public int FloorNumber { get; set; }
        public decimal Price { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public ICollection<PhotoPath> PhotoPaths { get; set; }
    }
}
