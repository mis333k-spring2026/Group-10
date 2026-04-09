using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class Card
    {
        [Key]
        public int CardID { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; } = "";

        [Required]
        [Display(Name = "Card Type")]
        public string CardType { get; set; } = "";

        public bool Status { get; set; } = true;

        [Required]
        public string CustomerID { get; set; } = "";

        public AppUser? Customer { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        [Display(Name = "Masked Card")]
        public string MaskedCardNumber
        {
            get
            {
                if (string.IsNullOrWhiteSpace(CardNumber) || CardNumber.Length < 4)
                {
                    return "";
                }

                string lastFour = CardNumber.Substring(CardNumber.Length - 4);
                return $"{CardType} ending in {lastFour}";
            }
        }
    }
}