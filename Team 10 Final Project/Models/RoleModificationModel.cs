using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class RoleModificationModel
    {
        [Required]
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }

    public class RoleEditModel
    {
        public Microsoft.AspNetCore.Identity.IdentityRole Role { get; set; }
        public System.Collections.Generic.List<AppUser> RoleMembers { get; set; }
        public System.Collections.Generic.List<AppUser> RoleNonMembers { get; set; }
    }
}
