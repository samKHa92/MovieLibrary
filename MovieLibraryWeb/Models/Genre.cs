using System;
using System.ComponentModel.DataAnnotations;

namespace MovieLibraryWeb.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
