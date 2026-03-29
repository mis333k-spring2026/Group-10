using System.Collections.Generic;
using Team_10_Final_Project.Models;

namespace Team_10_Final_Project.ViewModels
{
    public class ManageEmployeesViewModel
    {
        public List<AppUser> Employees { get; set; } = new List<AppUser>();
        public List<AppUser> Managers { get; set; } = new List<AppUser>();
        public List<AppUser> FormerEmployees { get; set; } = new List<AppUser>();
    }
}