using System.ComponentModel.DataAnnotations;

namespace BookStore_API.DTOs
{
    public class UpdateBookDto
    {
        [Required]
        [MinLength(2)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(2)]
        public string Author { get; set; } = string.Empty;

        [Range(1500, 2100)]
        public int Year { get; set; }
    }
}
