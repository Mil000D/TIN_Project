using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.RepertoireDTOs;

namespace TIN_Project.Server.Mappers.RepertoireMappers
{
    public interface IRepertoireMapper
    {
        public List<GetRepertoireDTO> MapRepertoiresToGetRepertoireDTOs(ICollection<Repertoire> repertoires);
        public Repertoire MapAddRepertoireDTOToRepertoire(AddRepertoireDTO addRepertoireDTO);
    }
}
