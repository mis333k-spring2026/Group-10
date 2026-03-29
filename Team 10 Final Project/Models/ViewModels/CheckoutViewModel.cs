using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Team_10_Final_Project.ViewModels
{
    public class CheckoutViewModel
    {
        public CartViewModel Cart { get; set; }

        [Display(Name = "Selected Card")]
        public int? SelectedCardID { get; set; }

        public SelectList? AvailableCards { get; set; }

        [Display(Name = "Use New Card")]
        public bool UseNewCard { get; set; }

        [Display(Name = "New Card Number")]
        public string? NewCardNumber { get; set; }

        [Display(Name = "Gift Purchase")]
        public bool IsGift { get; set; }

        [Display(Name = "Friend Email")]
        [EmailAddress]
        public string? FriendEmail { get; set; }
    }
}