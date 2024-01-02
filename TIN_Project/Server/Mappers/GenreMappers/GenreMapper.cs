using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Server.Mappers.GenreMappers
{
    public class GenreMapper : IGenreMapper
    {
        public List<GenreDTO> MapGenresToGenreDTOs(ICollection<Genre> genres)
        {
            return genres.Select(genre => new GenreDTO
            {
                IdGenre = genre.IdGenre,
                Name = genre.Name
            }).ToList();
        }

        public List<Genre> MapGenreDTOsToGenres(ICollection<GenreDTO> genreDTOs)
        {
            return genreDTOs.Select(genreDTO => new Genre
            {
                IdGenre = genreDTO.IdGenre,
                Name = genreDTO.Name
            }).ToList();
        }
    }
}
