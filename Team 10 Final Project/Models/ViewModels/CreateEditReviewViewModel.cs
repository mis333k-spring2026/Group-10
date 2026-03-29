using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.ViewModels
{
    public class CreateEditReviewViewModel
    {
        public int? ReviewID { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [StringLength(100, ErrorMessage = "Review cannot exceed 100 characters.")]
        [Display(Name = "Review")]
        public string? ReviewText { get; set; }

        public int? SongID { get; set; }
        public int? AlbumID { get; set; }
        public int? ArtistID { get; set; }
    }
}