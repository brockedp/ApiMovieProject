﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPIProject.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }

        public string Genre { get; set; }
        public string Director { get; set; }

        public string Actors { get; set; }
        public string Plot { get; set; }

    }
}
