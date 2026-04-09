using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; } = "";

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "State")]
        public string? State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; } = "";

        public bool Status { get; set; } = true;
    }
}