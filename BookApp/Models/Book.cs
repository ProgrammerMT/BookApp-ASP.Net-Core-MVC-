using System.ComponentModel.DataAnnotations;

namespace BooksApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        [Range(1, 2100, ErrorMessage = "Year must be between 1 and 2100")]
        public int YearPublished { get; set; }
    }
}
