using Microsoft.AspNetCore.Identity;

namespace _3dhi.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public override Guid Id { get; set; }
    }
}
