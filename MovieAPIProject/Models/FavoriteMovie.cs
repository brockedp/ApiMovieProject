using System;
using System.Collections.Generic;

namespace MovieAPIProject.Models
{
    public partial class FavoriteMovie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
    }
}
