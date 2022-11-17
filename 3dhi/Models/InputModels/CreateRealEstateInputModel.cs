using _3dhi.Data.Entities;

namespace _3dhi.Models.InputModels
{
    public class CreateRealEstateInputModel
    {
        public string OwnerName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public int FloorNumber { get; set; }
        public decimal Price { get; set; }
        public ICollection<PhotoPath> PhotoPaths { get; set; }
    }
}
