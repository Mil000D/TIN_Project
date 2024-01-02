using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Server.Mappers.GenreMappers
{
    public interface IGenreMapper
    {
        public List<GenreDTO> MapGenresToGenreDTOs(ICollection<Genre> genres);
        public List<Genre> MapGenreDTOsToGenres(ICollection<GenreDTO> genreDTOs);
    }
}
