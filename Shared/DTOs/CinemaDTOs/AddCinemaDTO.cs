using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.CinemaDTOs
{
    public class AddCinemaDTO
    {
        [Required(ErrorMessageResourceName = "NameRequiredError", ErrorMessageResourceType = typeof(Resources.CinemaDTOsResources.Cinema))]
        [MaxLength(30, ErrorMessageResourceName = "NameLengthError", ErrorMessageResourceType = typeof(Resources.CinemaDTOsResources.Cinema))]
        public string Name { get; set; }
        [Required(ErrorMessageResourceName = "AddressRequiredError", ErrorMessageResourceType = typeof(Resources.CinemaDTOsResources.Cinema))]
        [MaxLength(40, ErrorMessageResourceName = "AddressLengthError", ErrorMessageResourceType = typeof(Resources.CinemaDTOsResources.Cinema))]
        public string Address { get; set; }
    }
}
