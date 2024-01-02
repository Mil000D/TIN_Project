using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.GenreDTOs
{
    public class GenreDTO
    {
        public int IdGenre { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public override bool Equals(object o)
        {
            var other = o as GenreDTO;
            return other?.IdGenre == IdGenre;
        }

        public override int GetHashCode() => IdGenre.GetHashCode();
    }
}
