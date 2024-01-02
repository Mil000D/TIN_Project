using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.UserDTOs
{
    public class AddAdminDTO
    {
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Surname { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
    }
}
