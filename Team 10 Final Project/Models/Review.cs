using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [StringLength(100, ErrorMessage = "Review cannot exceed 100 characters.")]
        [Display(Name = "Review")]
        public string? ReviewText { get; set; }

        // false = pending, true = approved
        [Required]
        public bool Status { get; set; } = false;

        [Required]
        public string ReviewerID { get; set; } = "";

        public AppUser? Reviewer { get; set; }

        public string? ApproverID { get; set; }
        public AppUser? Approver { get; set; }

        public int? SongID { get; set; }
        public Song? Song { get; set; }

        public int? AlbumID { get; set; }
        public Album? Album { get; set; }

        public int? ArtistID { get; set; }
        public Artist? Artist { get; set; }

        public Boolean IsApproved { get; set; } = false;
        public Boolean IsRejected { get; set; } = false;
    }
}