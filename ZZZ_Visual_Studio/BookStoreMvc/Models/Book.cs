using System.ComponentModel.DataAnnotations;

namespace BookStoreMvc.Models
{
    public class Book
    {
        [Key] // Marks this as the primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")] // Validation rule
        public string? Title { get; set; }

        [Required]
        public string? Author { get; set; }

        [Range(0.01, 1000, ErrorMessage = "Price must be between 0.01 and 1000")]
        public decimal Price { get; set; }
    }
}
