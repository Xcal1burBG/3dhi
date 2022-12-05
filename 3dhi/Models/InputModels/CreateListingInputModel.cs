using _3dhi.Data.Entities;
using _3dhi.Enum;

namespace _3dhi.Models.InputModels
{
    public class CreateListingInputModel
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string MainPhotoPath { get; set; }
        
    }
}
