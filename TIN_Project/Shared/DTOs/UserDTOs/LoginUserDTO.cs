using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.UserDTOs
{
    public class LoginUserDTO
    {
        [Required(ErrorMessageResourceName = "UsernameRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string Username { get; set; }
        [Required(ErrorMessageResourceName = "PasswordRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string Password { get; set; }
    }
}
