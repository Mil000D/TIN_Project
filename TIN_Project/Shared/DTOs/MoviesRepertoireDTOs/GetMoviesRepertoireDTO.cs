namespace TIN_Project.Shared.DTOs.MoviesRepertoireDTOs
{
    public class GetMoviesRepertoireDTO
    {
        public int IdMoviesRepertoire { get; set; }
        public int IdMovie { get; set; }
        public string PosterUrl { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly ShowTime { get; set; }
        public string CinemaName { get; set; }
        public string CinemaAddress { get; set; }
    }
}
