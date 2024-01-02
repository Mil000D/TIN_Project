using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Context;
using TIN_Project.Server.Mappers.GenreMappers;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Server.Services.GenresServices
{
    public class GenresDbService : IGenresDbService
    {
        private readonly MainDbContext _context;
        public GenresDbService(MainDbContext context)
        {
            _context = context;
        }
        public async Task<List<Genre>> GetGenresAsync()
        {
            return await _context.Genres.OrderBy(g => g.Name).ToListAsync();
        }
        public async Task<Genre?> GetGenreByIdAsync(int id)
        {
            return await _context.Genres.FirstOrDefaultAsync(g => g.IdGenre == id);
        }
        public async Task DeleteGenreAsync(Genre genre)
        {
            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateGenreAsync(Genre genreToUpdate, GenreDTO genreDTO)
        {
            genreToUpdate.Name = genreDTO.Name;
            await _context.SaveChangesAsync();
        }
        public async Task AddGenreAsync(GenreDTO genreDTO)
        {
            var genre = new Genre
            {
                Name = genreDTO.Name
            };
            _context.Genres.Add(genre);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> IsNameUniqueAsync(GenreDTO genreDTO)
        {
            var genreFromDb = await _context.Genres.FirstOrDefaultAsync(g => g.Name == genreDTO.Name && g.IdGenre != genreDTO.IdGenre);
            return genreFromDb == null;
        }
    }
}
