using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLibraryWeb.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Director Director { get; set; }
        public List<Actor> Actors { get; set; }
        public int Budget { get; set; }
        public int Income { get; set; }

        [Required]
        public int IMDBRating { get; set; }
        [Required]
        public int RottenTomatoesRating { get; set; }

        public string Poster { get; set; }
    }
}
