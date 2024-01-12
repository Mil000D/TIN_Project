namespace TIN_Project.Server.Models
{
	public class Genre
	{
		public int IdGenre { get; set; }
		public string EnglishName { get; set; }
		public string PolishName { get; set; }
		public ICollection<Movie> Movies { get; set; }
	}
}
