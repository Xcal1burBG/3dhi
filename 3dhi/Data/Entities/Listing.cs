using _3dhi.Enum;

namespace _3dhi.Data.Entities
{
    public class Listing
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int placesAdults { get; set; }
        public int placesChildren { get; set; }
        public string MainPhotoPath { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public virtual User User { get; set; }

        #nullable enable
        public ICollection<PhotoPath>? PhotoPaths { get; set; }
    }
}
