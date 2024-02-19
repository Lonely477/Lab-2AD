using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public DateTime? ReleaseDate { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Range(1, 20, ErrorMessage = "NumberInStock field must be between 1 and 20.")]
        public int NumberInStock { get; set; }
    }
}