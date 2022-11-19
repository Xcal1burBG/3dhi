using Microsoft.AspNetCore.Identity;
using System.Security.Policy;

namespace _3dhi.Data.Entities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public override Guid UserId { get; set; }
        public override Guid RoleId { get; set; }
    }
}
