using System.ComponentModel.DataAnnotations;

namespace CodeFirstPractice.Models
{
    public class Movie
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Title must be provided
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(1900, 2100)] // Ensure a valid release year
        public int ReleaseYear { get; set; }
    }
}
