using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.RepertoireDTOs
{
    public class AddRepertoireDTO
    {
        [Required]
        public int IdCinema { get; set; }
        [Required]
        public DateTime? Date { get; set; }
    }
}
