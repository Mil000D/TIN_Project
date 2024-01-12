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
                EnglishName = genre.EnglishName,
                PolishName = genre.PolishName
            }).ToList();
        }

        public List<Genre> MapGenreDTOsToGenres(ICollection<GenreDTO> genreDTOs)
        {
            return genreDTOs.Select(genreDTO => new Genre
            {
                IdGenre = genreDTO.IdGenre,
                EnglishName = genreDTO.EnglishName,
                PolishName = genreDTO.PolishName
            }).ToList();
        }
    }
}
