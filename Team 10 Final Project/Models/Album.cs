using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class Album
    {
        [Key]
        public Int32 AlbumID { get; set; }

        [Required]
        [Display(Name = "Album Name")]
        // TODO: Change to public String? AlbumName { get; set; }
        public String AlbumName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public Decimal Price { get; set; }

        [Display(Name = "Album Cover")]
        // TODO: Change to public String? AlbumCover { get; set; }
        public String AlbumCover { get; set; }

        public Boolean Status { get; set; } = true;

        //navigation properties
        //many to many relationship
        public List<Artist> Artists { get; set; } = new List<Artist>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}