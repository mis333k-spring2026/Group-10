using System.Collections.Generic;
using Team10FinalProject.Models;

namespace Team10FinalProject.ViewModels
{
    public class OrderHistoryViewModel
    {
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}