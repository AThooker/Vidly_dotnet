﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //nav property
        [Required]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        [Display(Name = "Released Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }
    }
}