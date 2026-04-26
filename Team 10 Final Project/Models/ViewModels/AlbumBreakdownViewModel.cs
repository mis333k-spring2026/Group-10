using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.ViewModels
{
    public class AlbumBreakdownViewModel
    {
        [Display(Name = "Album Title")]
        public string AlbumTitle { get; set; }

        [Display(Name = "Purchases")]
        public int AlbumPurchases { get; set; }

        [Display(Name = "Revenue")]
        [DataType(DataType.Currency)]
        public decimal AlbumRevenue { get; set; }
    }
}