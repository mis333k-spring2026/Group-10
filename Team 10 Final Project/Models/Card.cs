using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.Models
{
    public class Card
    {
        [Key]
        public Int32 CardID { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public String CardNumber { get; set; }

        [Required]
        [Display(Name = "Card Type")]
        public String CardType { get; set; }

        public Boolean Status { get; set; } = true;

        [Required]
        public String CustomerID { get; set; }
        public AppUser Customer { get; set; }

        // navigation property
        public List<Order> Orders { get; set; } = new List<Order>();

        [Display(Name = "Masked Card")]
        public String MaskedCardNumber
        {
            get
            {
                if (String.IsNullOrEmpty(CardNumber) || CardNumber.Length < 4)
                {
                    return "";
                }

                String lastFour = CardNumber.Substring(CardNumber.Length - 4);
                return $"**** **** **** {lastFour}";
            }
        }
    }
}