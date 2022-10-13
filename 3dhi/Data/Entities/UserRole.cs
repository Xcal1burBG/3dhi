using Microsoft.AspNetCore.Identity;

namespace _3dhi.Data.Entities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public override Guid UserId { get; set; }
        public override Guid RoleId { get; set; }
        
    }
}
