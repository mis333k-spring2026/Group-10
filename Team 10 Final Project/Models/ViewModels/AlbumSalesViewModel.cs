using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.ViewModels
{
    public class AlbumSalesViewModel
    {
        [Display(Name = "Album Title")]
        public string AlbumTitle { get; set; }

        [Display(Name = "Artist")]
        public string ArtistName { get; set; }

        [Display(Name = "Number of Purchases")]
        public int PurchaseCount { get; set; }

        [Display(Name = "Revenue")]
        [DataType(DataType.Currency)]
        public decimal Revenue { get; set; }
    }
}