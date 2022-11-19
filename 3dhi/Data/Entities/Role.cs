using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _3dhi.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        [Key]
        public override Guid Id { get; set; }
        public string Discriminator { get; set; }
        
    }
}
