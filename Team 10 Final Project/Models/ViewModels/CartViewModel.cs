using System.Collections.Generic;
using System.Linq;

namespace Team_10_Final_Project.ViewModels
{
    public class CartViewModel
    {
        public List<CartItemViewModel> Items { get; set; } = new List<CartItemViewModel>();

        public decimal Subtotal => Items.Sum(i => i.Price);
        public decimal Tax => Subtotal * 0.0825m;
        public decimal Total => Subtotal + Tax;

        public Boolean HasDuplicateSongs { get; set; }
        public List<string> DuplicateMessages { get; set; } = new List<string>();
    }
}