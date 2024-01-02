using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.CinemaDTOs
{
    public class AddCinemaDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(40)]
        public string Address { get; set; }
    }
}
