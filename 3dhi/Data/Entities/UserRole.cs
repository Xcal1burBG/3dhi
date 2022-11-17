using Microsoft.AspNetCore.Identity;

namespace _3dhi.Data.Entities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public new Guid UserId { get; set; }
        public new Guid RoleId { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
