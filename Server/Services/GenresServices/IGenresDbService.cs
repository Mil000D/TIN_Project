using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Server.Services.GenresServices
{
    public interface IGenresDbService
    {
        public Task<List<Genre>> GetGenresAsync();
        public Task<Genre?> GetGenreByIdAsync(int id);
        public Task DeleteGenreAsync(Genre genre);
        public Task UpdateGenreAsync(Genre genreToUpdate, GenreDTO genreDTO);
        public Task AddGenreAsync(GenreDTO genreDTO);

        public Task<bool> IsNameUniqueAsync(GenreDTO genreDTO);

    }
}
