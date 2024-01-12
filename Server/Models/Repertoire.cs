namespace TIN_Project.Server.Models
{
	public class Repertoire
	{
		public int IdRepertoire { get; set; }
		public DateOnly Date { get; set; }
		public int IdCinema { get; set; }
		public Cinema Cinema { get; set; }
		public ICollection<MovieRepertoire> MovieRepertoires { get; set; }
	}
}
