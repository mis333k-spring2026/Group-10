using System;
using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.Models
{
    public class Review
    {
        [Key]
        public Int32 ReviewID { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Rating")]
        public Int32 Rating { get; set; }

        [StringLength(100, ErrorMessage = "Review cannot exceed 100 characters.")]
        [Display(Name = "Review")]
        public String ReviewText { get; set; }

        [Required]
        public Boolean Status { get; set; } = false;

        // reviewer
        [Required]
        public String ReviewerID { get; set; }
        public AppUser Reviewer { get; set; }

        // approver
        public String ApproverID { get; set; }
        public AppUser Approver { get; set; }

        // optional relationships: a review is for ONE of these
        public Int32? SongID { get; set; }
        public Song Song { get; set; }

        public Int32? AlbumID { get; set; }
        public Album Album { get; set; }

        public Int32? ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}