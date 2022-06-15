using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //nav property
        public GenreDto Genre { get; set; }
        [Required]
        public int? GenreId { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        //[Required]
        //[Column(TypeName = "datetime2")]
        public DateTime? ReleaseDate { get; set; }
        //[Column(TypeName = "datetime2")]
        public DateTime DateAdded { get; set; }
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}