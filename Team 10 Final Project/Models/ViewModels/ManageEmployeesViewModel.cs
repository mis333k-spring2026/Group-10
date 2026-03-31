using System.Collections.Generic;
using Team10FinalProject.Models;

namespace Team10FinalProject.ViewModels
{
    public class ManageEmployeesViewModel
    {
        public List<AppUser> Employees { get; set; } = new List<AppUser>();
        public List<AppUser> Managers { get; set; } = new List<AppUser>();
        public List<AppUser> FormerEmployees { get; set; } = new List<AppUser>();
    }
}