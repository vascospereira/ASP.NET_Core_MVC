using System;
using System.ComponentModel.DataAnnotations;

namespace MVCMovieApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }
        [Display(Name = "Release Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseTime { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", 
            ErrorMessage = "Genre must begin with a capital letter and consist of only letters or spaces"), 
            StringLength(30), Required]
        public string Genre { get; set; }
        [Range(1,100), DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-F]+[A-F]*${2}",
            ErrorMessage = "The field Rating must be a tripple character from A to F with a maximum length of 3"), 
            StringLength(3), Required]
        public string Rating { get; set; }
    }
}
