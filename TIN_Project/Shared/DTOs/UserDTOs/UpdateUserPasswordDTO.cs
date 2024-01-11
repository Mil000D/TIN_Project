using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.UserDTOs
{
    public class UpdateUserPasswordDTO
    {
        [Required(ErrorMessageResourceName = "PasswordRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [MaxLength(20, ErrorMessageResourceName = "PasswordLengthError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string OldPassword { get; set; }
        [Required(ErrorMessageResourceName = "PasswordRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [MaxLength(20, ErrorMessageResourceName = "PasswordLengthError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string NewPassword { get; set; }
    }
}
