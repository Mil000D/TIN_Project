using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.RepertoireDTOs;

namespace TIN_Project.Server.Mappers.RepertoireMappers
{
    public class RepertoireMapper : IRepertoireMapper
    {
        public List<GetRepertoireDTO> MapRepertoiresToGetRepertoireDTOs(ICollection<Repertoire> repertoires)
        {
            return repertoires.Select(repertoire => new GetRepertoireDTO
            {
                IdRepertoire = repertoire.IdRepertoire,
                Date = repertoire.Date.ToDateTime(TimeOnly.Parse("0:00"))
            }).ToList();
        }

        public Repertoire MapAddRepertoireDTOToRepertoire(AddRepertoireDTO addRepertoireDTO)
        {
            return new Repertoire
            {
                Date = DateOnly.FromDateTime((DateTime)addRepertoireDTO.Date)
            };
        }
    }
}
