using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title cannot be null")]
        public string Title { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "Your data format is wrong, please, use yyyy/mm/dd")]
        [Required(ErrorMessage = "Realese date cannot be null")]
        public DateTime ReleasedAt { get; set; }
        [StringLength(maximumLength:30,MinimumLength = 3, ErrorMessage = "Please, the title must have Maximum Length: 30, Minimum Length: 3")]
        [RegularExpression(@"^[A-Z]+[a-z-A-Z\u00c0-\u00FF""'\w-*$", ErrorMessage = "Gender in incorrect format")]
        public string Gender { get; set; }
        [Range(minimum:1, maximum: 30000, ErrorMessage = "The value must be between 1 and 30000")]
        [Required(ErrorMessage = "Price cannot be null")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[1-1000]*$",ErrorMessage ="The rate must be a number")]
        [Range(minimum:1, maximum:5, ErrorMessage = "The rate must be between 1 and 5")]
        [Required(ErrorMessage = "Rate cannot be null")]
        public int Rate { get; set; }
        [StringLength(maximumLength: 70, MinimumLength = 10,ErrorMessage = "Please, the title must have Maximum Length: 70, Minimum Length: 10")]
        [Required(ErrorMessage ="Description cannot be null")]
        public string Description { get; set; }
    }
}
