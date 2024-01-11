using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.UserDTOs
{
    public class RegisterUserDTO
    {
        [Required(ErrorMessageResourceName = "UsernameRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [MaxLength(20, ErrorMessageResourceName = "UsernameLengthError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string Username { get; set; }
        [Required(ErrorMessageResourceName = "PasswordRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [MaxLength(20, ErrorMessageResourceName = "PasswordLengthError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string Password { get; set; }
        [Required(ErrorMessageResourceName = "RepeatPasswordRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [MaxLength(20, ErrorMessageResourceName = "RepeatPasswordLengthError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [Compare("Password", ErrorMessageResourceName = "RepeatPasswordCompareError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string RepeatPassword { get; set; }
        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [EmailAddress(ErrorMessageResourceName = "EmailAddressError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [MaxLength(30, ErrorMessageResourceName = "EmailLengthError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string Email { get; set; }
        [Required(ErrorMessageResourceName = "NameRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [MaxLength(20, ErrorMessageResourceName = "NameLengthError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string Name { get; set; }
        [Required(ErrorMessageResourceName = "SurnameRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        [MaxLength(20, ErrorMessageResourceName = "SurnameLengthError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public string Surname { get; set; }
        [Required(ErrorMessageResourceName = "BirthDateRequiredError", ErrorMessageResourceType = typeof(Resources.UserDTOsResources.User))]
        public DateTime? BirthDate { get; set; } = DateTime.Today;
    }
}
