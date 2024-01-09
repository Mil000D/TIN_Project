using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.UserDTOs
{
    public class UpdateUserPasswordDTO
    {
        [Required]
        [MaxLength(20)]
        public string OldPassword { get; set; }
        [Required]
        [MaxLength(20)]
        public string NewPassword { get; set; }
    }
}
