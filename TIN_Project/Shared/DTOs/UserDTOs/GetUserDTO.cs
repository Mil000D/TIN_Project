namespace TIN_Project.Shared.DTOs.UserDTOs
{
    public class GetUserDTO
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public bool IsAdmin { get; set; }
    }
}
