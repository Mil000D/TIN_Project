namespace TIN_Project.Server.Models
{
	public class MovieRepertoire
	{
		public int IdMovieRepertoire { get; set; }
		public int IdMovie { get; set; }
		public Movie Movie { get; set; }
		public int IdRepertoire { get; set; }
		public Repertoire Repertoire { get; set; }
		public TimeOnly ShowTime { get; set; }
		public ICollection<Order> Orders { get; set; }
	}
}
