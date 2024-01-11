using System.ComponentModel.DataAnnotations;

namespace TIN_Project.Shared.DTOs.RepertoireDTOs
{
    public class UpdateRepertoireDTO
    {
        public int IdRepertoire { get; set; }
        [Required(ErrorMessageResourceName = "DateRequiredError", ErrorMessageResourceType = typeof(Resources.RepertoireDTOsResources.Repertoire))]
        public DateTime? Date { get; set; }
        [Required]
        public int IdCinema { get; set; }
    }
}
