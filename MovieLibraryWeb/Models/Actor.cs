using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLibraryWeb.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public float Rating { get; set; }
        public string Portrait { get; set; }
        public List<Movie> Movies { get; set; }

        public Actor()
        {
            this.Movies = new List<Movie>();
        }
    }
}
