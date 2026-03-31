using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.ViewModels
{
    public class AddCardViewModel
    {
        public int? CardID { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }
    }
}