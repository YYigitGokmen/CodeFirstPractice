using System.ComponentModel.DataAnnotations;

namespace CodeFirstPractice.Models
{
    public class Game
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Name must be provided
        public string Name { get; set; }

        [Required]
        public string Platform { get; set; }

        [Range(0, 10)] // Ensure the rating is between 0 and 10
        public decimal Rating { get; set; }
    }
}
