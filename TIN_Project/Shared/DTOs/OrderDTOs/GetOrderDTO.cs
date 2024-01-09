namespace TIN_Project.Shared.DTOs.OrderDTOs
{
    public class GetOrderDTO
    {
        public int IdMovieRepertoire { get; set; }
        public string MoviePosterUrl { get; set; }
        public string MovieTitle { get; set; }
        public string CinemaName { get; set; }
        public string CinemaAddress { get; set; }
        public DateOnly ShowDate { get; set; }
        public TimeOnly ShowTime { get; set; }
        public bool IsPaid { get; set; }
    }
}
