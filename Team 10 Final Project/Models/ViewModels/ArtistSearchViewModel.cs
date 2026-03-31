using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Team10FinalProject.Models;

namespace Team10FinalProject.ViewModels
{
    public class ArtistSearchViewModel
    {
        [Display(Name = "Artist Name")]
        public String? SearchArtistName { get; set; }

        [Display(Name = "Genres")]
        public List<Int32> SelectedGenreIDs { get; set; } = new List<Int32>();

        [Display(Name = "Rating Filter")]
        public Decimal? RatingValue { get; set; }

        [Display(Name = "Rating Comparison")]
        public String? RatingComparison { get; set; }

        [Display(Name = "Sort By")]
        public String? SortOption { get; set; }

        public SelectList? AllGenres { get; set; }

        public List<Artist> SearchResults { get; set; } = new List<Artist>();

        public Int32 SelectedResultsCount => SearchResults.Count;

        public Int32 TotalResultsCount { get; set; }
    }
}