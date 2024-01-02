using TIN_Project.Server.Enums;

namespace TIN_Project.Server.Models
{
	public class User
	{
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
		public string Surname { get; set; }
		public DateOnly BirthDate { get; set; }
		public Role Role { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpirationDate { get; set; }
        public ICollection<Order> Orders { get; set; }
	}
}
