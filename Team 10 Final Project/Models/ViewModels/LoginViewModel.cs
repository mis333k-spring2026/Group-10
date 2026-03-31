using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public Boolean RememberMe { get; set; }

    }
}
