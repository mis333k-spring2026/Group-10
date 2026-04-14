using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Display(Name = "Order Number")]
        public int OrderNumber { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Status")]
        public bool Status { get; set; } = true;

        [Required]
        public string CustomerID { get; set; } = "";

        public AppUser? Customer { get; set; }

        public string? FriendID { get; set; }
        public AppUser? Friend { get; set; }

        public int? CardID { get; set; }
        public Card? Card { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}