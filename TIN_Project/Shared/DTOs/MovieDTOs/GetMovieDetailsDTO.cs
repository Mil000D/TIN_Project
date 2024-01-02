using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Shared.DTOs.MovieDTOs
{
    public class GetMovieDetailsDTO
    {
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<GenreDTO> Genres { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly ShowTime { get; set; }
        public string CinemaName { get; set; }
        public string CinemaAddress { get; set; }
    }
}
