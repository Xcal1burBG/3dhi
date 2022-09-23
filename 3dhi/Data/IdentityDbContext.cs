using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace _3dhi.Data
{
    public abstract class IdentityDbContext<
    User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    : IdentityUserContext<User, Guid, UserClaim, UserLogin, UserToken>
         where User : IdentityUser<Guid>
         where Role : IdentityRole<Guid>
         where Guid : IEquatable<Guid>
         where UserClaim : IdentityUserClaim<Guid>
         where UserRole : IdentityUserRole<Guid>
         where UserLogin : IdentityUserLogin<Guid>
         where RoleClaim : IdentityRoleClaim<Guid>
         where UserToken : IdentityUserToken<Guid>
    {

    }
}
