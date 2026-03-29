using System.Collections.Generic;
using Team_10_Final_Project.Models;

namespace Team_10_Final_Project.ViewModels
{
    public class OrderHistoryViewModel
    {
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}