using _3dhi.Enum;

namespace _3dhi.Models
{
    public sealed class Listing
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string MainPhoto { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public User User { get; set; }
        public ICollection<PhotoPath>? PhotoPaths { get; set; }
    }
}
