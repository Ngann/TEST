﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ReactTemplate.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public decimal Review { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }

    }
}
