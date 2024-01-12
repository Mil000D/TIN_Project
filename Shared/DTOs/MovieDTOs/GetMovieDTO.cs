using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Shared.DTOs.MovieDTOs
{
    public class GetMovieDTO
    {
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }
        public ICollection<GenreDTO> Genres { get; set; }
        public override bool Equals(object o)
        {
            var other = o as GetMovieDTO;
            return other?.IdMovie == IdMovie;
        }
        public override int GetHashCode() => IdMovie.GetHashCode();
    }
}
