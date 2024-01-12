using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.CinemaDTOs;

namespace TIN_Project.Server.Mappers.CinemaMappers
{
    public interface ICinemaMapper
    {
        public List<GetCinemaDTO> MapCinemasToGetCinemaDTOs(List<Cinema> cinemas);
        public Cinema MapAddCinemaDTOToCinema(AddCinemaDTO addCinemaDTO);
    }
}
