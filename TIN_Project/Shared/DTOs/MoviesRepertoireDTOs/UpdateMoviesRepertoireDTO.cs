using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.MoviesRepertoireDTOs
{
    public class UpdateMoviesRepertoireDTO
    {
        public int IdMoviesRepertoire { get; set; }
        public int IdRepertoire { get; set; }
        public int IdMovie { get; set; }
        [Required]
        public TimeOnly ShowTime { get; set; }
    }
}
