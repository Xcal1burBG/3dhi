using Microsoft.AspNetCore.Identity;

namespace _3dhi.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public new Guid Id { get; set; }
        public string Discriminator { get; set; }
        //public ICollection<UserRole> UserRoles { get; set; }
    }
}
