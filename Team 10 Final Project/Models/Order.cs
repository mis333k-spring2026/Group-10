using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.Models
{
    public class Order
    {
        [Key]
        public Int32 OrderID { get; set; }

        [Required]
        [Display(Name = "Order Number")]
        public Int32 OrderNumber { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Required]
        public Boolean Status { get; set; } = true;

        // customer who placed the order
        [Required]
        public String CustomerID { get; set; }
        public AppUser Customer { get; set; }

        // optional gift recipient
        public String? FriendID { get; set; }
        public AppUser? Friend { get; set; }

        // card used for payment
        [Required]
        public Int32 CardID { get; set; }
        public Card Card { get; set; }

        // one order has many order details
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}