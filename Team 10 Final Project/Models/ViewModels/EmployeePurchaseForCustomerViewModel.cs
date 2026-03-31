using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Team10FinalProject.ViewModels
{
    public class EmployeePurchaseForCustomerViewModel
    {
        [Required]
        [Display(Name = "Customer")]
        public string SelectedCustomerID { get; set; }

        public SelectList? Customers { get; set; }

        public CartViewModel Cart { get; set; } = new CartViewModel();

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