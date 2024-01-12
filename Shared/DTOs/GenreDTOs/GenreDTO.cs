using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.GenreDTOs
{
    public class GenreDTO
    {
        public int IdGenre { get; set; }
        [Required(ErrorMessageResourceName = "GenreRequiredError", ErrorMessageResourceType = typeof(Resources.GenreDTOsResources.Genre))]
        [MaxLength(40, ErrorMessageResourceName = "GenreLengthError", ErrorMessageResourceType = typeof(Resources.GenreDTOsResources.Genre))]
        public string EnglishName { get; set; }
        [Required(ErrorMessageResourceName = "GenreRequiredError", ErrorMessageResourceType = typeof(Resources.GenreDTOsResources.Genre))]
        [MaxLength(40, ErrorMessageResourceName = "GenreLengthError", ErrorMessageResourceType = typeof(Resources.GenreDTOsResources.Genre))]
        public string PolishName { get; set; }
        public override bool Equals(object o)
        {
            var other = o as GenreDTO;
            return other?.IdGenre == IdGenre;
        }

        public override int GetHashCode() => IdGenre.GetHashCode();
    }
}
