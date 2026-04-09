using Team10FinalProject.Models;

namespace Team10FinalProject.ViewModels
{
    public class AddUserModel
    {
        public AppUser User { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
    }
}
