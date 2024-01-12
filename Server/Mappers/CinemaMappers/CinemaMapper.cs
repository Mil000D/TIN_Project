using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.CinemaDTOs;

namespace TIN_Project.Server.Mappers.CinemaMappers
{
    public class CinemaMapper : ICinemaMapper
    {
        public List<GetCinemaDTO> MapCinemasToGetCinemaDTOs(List<Cinema> cinemas)
        {
            return cinemas.Select(cinema => new GetCinemaDTO
            {
                IdCinema = cinema.IdCinema,
                Name = cinema.Name,
                Address = cinema.Address
            }).ToList();
        }
        public Cinema MapAddCinemaDTOToCinema(AddCinemaDTO addCinemaDTO)
        {
            return new Cinema
            {
                Name = addCinemaDTO.Name,
                Address = addCinemaDTO.Address
            };
        }

    }
}
