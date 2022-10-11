using _3dhi.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace _3dhi.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public new Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime BirhDate { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsHost { get; set; }
        public EntityStatus EntityStatus { get; set; }

#nullable enable
        public  ICollection<Listing>? Listings { get; set; }


    }
}
