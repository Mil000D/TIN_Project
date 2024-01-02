namespace TIN_Project.Server.Models
{
	public class Genre
	{
		public int IdGenre { get; set; }
		public string Name { get; set; }
		public ICollection<Movie> Movies { get; set; }
	}
}
