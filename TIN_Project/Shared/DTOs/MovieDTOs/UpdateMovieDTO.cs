using System.ComponentModel.DataAnnotations;
using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Shared.DTOs.MovieDTOs
{
    public class UpdateMovieDTO
    {
        public int IdMovie { get; set; }
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string TrailerUrl { get; set; }
        [Required]
        [MaxLength(100)]
        public string PosterUrl { get; set; }
        public ICollection<GenreDTO> Genres { get; set; }

    }
}
