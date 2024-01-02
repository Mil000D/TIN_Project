using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.RepertoireDTOs
{
    public class UpdateRepertoireDTO
    {
        public int IdRepertoire { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Required]
        public int IdCinema { get; set; }
    }
}
