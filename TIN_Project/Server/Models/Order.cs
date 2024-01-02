namespace TIN_Project.Server.Models
{
	public class Order
	{
		public int IdUser { get; set; }
		public User User { get; set; }
		public int IdMovieRepertoire { get; set; }
		public MovieRepertoire MovieRepertoire { get; set; }
		public bool IsPaid { get; set; }
	}
}
