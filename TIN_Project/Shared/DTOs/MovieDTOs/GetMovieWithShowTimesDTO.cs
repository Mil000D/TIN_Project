using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Shared.DTOs.MovieDTOs
{
    public class GetMovieWithShowTimesDTO
    {
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public ICollection<TimeOnly> ShowTimes { get; set; }
        public ICollection<GenreDTO> Genres { get; set; }
    }
}
