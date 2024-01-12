using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.MoviesRepertoireDTOs
{
    public class AddMoviesRepertoireDTO
    {
        public int IdMovie { get; set; }
        public int IdRepertoire { get; set; }
        [Required(ErrorMessageResourceName = "ShowTimeRequiredError", ErrorMessageResourceType = typeof(Resources.MoviesRepertoireDTOsResources.MoviesRepertoire))]
        public TimeOnly ShowTime { get; set; }
    }
}
