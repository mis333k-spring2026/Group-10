using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Team10FinalProject.ViewModels
{
    public class CreateEditAlbumViewModel
    {
        public int? AlbumID { get; set; }

        [Required]
        [Display(Name = "Album Name")]
        public string AlbumName { get; set; }

        [Required]
        [Display(Name = "Price")]
        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }

        [Display(Name = "Album Cover")]
        public string? AlbumCover { get; set; }

        [Required]
        [Display(Name = "Artist")]
        public int ArtistID { get; set; }

        public SelectList? AllArtists { get; set; }

        [Display(Name = "Genres")]
        public List<int> SelectedGenreIDs { get; set; } = new List<int>();

        public MultiSelectList? AllGenres { get; set; }

        [Display(Name = "Songs")]
        public List<int> SelectedSongIDs { get; set; } = new List<int>();

        public MultiSelectList? AllSongs { get; set; }

        [Display(Name = "Active")]
        public bool Status { get; set; } = true;
    }
}