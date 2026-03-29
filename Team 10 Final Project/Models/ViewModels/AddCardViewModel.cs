using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.ViewModels
{
    public class AddCardViewModel
    {
        public int? CardID { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }
    }
}