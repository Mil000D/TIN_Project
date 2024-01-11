using System.ComponentModel.DataAnnotations;
using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Shared.DTOs.MovieDTOs
{
    public class AddMovieDTO
    {
        [Required(ErrorMessageResourceName = "TitleRequiredError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        [MaxLength(40, ErrorMessageResourceName = "TitleLengthError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        public string EnglishTitle { get; set; }
        [Required(ErrorMessageResourceName = "TitleRequiredError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        [MaxLength(40, ErrorMessageResourceName = "TitleLengthError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        public string PolishTitle { get; set; }
        [Required(ErrorMessageResourceName = "DescriptionRequiredError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        [MaxLength(1000, ErrorMessageResourceName = "DescriptionLengthError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        public string EnglishDescription { get; set; }
        [Required(ErrorMessageResourceName = "DescriptionRequiredError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        [MaxLength(1000, ErrorMessageResourceName = "DescriptionLengthError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        public string PolishDescription { get; set; }
        [Required(ErrorMessageResourceName = "TrailerRequiredError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        [MaxLength(100, ErrorMessageResourceName = "TrailerLengthError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        public string TrailerUrl { get; set; }
        [Required(ErrorMessageResourceName = "PosterRequiredError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        [MaxLength(100, ErrorMessageResourceName = "PosterLengthError", ErrorMessageResourceType = typeof(Resources.MovieDTOsResources.Movie))]
        public string PosterUrl { get; set; }
        public ICollection<GenreDTO> Genres { get; set; }
    }
}
