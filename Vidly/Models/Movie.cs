using System.ComponentModel.DataAnnotations;
using System;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        
        public DateTime DateAdded { get; set; }
        

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1,10)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}