namespace TIN_Project.Server.Models
{
	public class Movie
	{
		public int IdMovie { get; set; }
		public string EnglishTitle { get; set; }
		public string PolishTitle { get; set; }
		public string EnglishDescription { get; set; }
		public string PolishDescription { get; set; }
		public string TrailerUrl { get; set; }
		public string PosterUrl { get; set; }
		public ICollection<Genre> Genres { get; set; }
		public ICollection<MovieRepertoire> MovieRepertoires { get; set; }
	}
}
