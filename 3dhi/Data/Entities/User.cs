using _3dhi.Enum;
using Microsoft.AspNetCore.Identity;

namespace _3dhi.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsHost { get; set; }
        public EntityStatus EntityStatus { get; set; }

        public ICollection<Listing> Listings { get; set; }
    }
}
