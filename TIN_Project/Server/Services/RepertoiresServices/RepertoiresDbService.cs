using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Context;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.RepertoireDTOs;

namespace TIN_Project.Server.Services.RepertoiresServices
{
    public class RepertoiresDbService : IRepertoiresDbService
    {
        private readonly MainDbContext _context;
        public RepertoiresDbService(MainDbContext context)
        {
            _context = context;
        }
        public async Task<List<Repertoire>> GetRepertoiresWithCinemaIdAsync(int id)
        {
            return await _context.Repertoires.OrderBy(x => x.Date).Where(x => x.IdCinema == id).ToListAsync();
        }
        public async Task AddRepertoireForCinema(int idCinema, Repertoire repertoire)
        {
            var cinema = await _context.Cinemas.FirstOrDefaultAsync(x => x.IdCinema == idCinema);
            repertoire.Cinema = cinema;
            await _context.Repertoires.AddAsync(repertoire);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsDateUniqueAsync(AddRepertoireDTO addRepertoireDTO)
        {
            DateOnly dateOnly = DateOnly.FromDateTime((DateTime)addRepertoireDTO.Date);
            var repertoire = await _context.Repertoires.Where(x => x.IdCinema == addRepertoireDTO.IdCinema && x.Date.Equals(dateOnly)).FirstOrDefaultAsync();
            return repertoire == null;
        }

        public async Task<bool> IsDateUniqueAsync(UpdateRepertoireDTO updateRepertoireDTO)
        {
            DateOnly dateOnly = DateOnly.FromDateTime((DateTime)updateRepertoireDTO.Date);
            var repertoire = await _context.Repertoires.Where(x => x.IdCinema == updateRepertoireDTO.IdCinema && x.IdRepertoire != updateRepertoireDTO.IdRepertoire && x.Date.Equals(dateOnly)).FirstOrDefaultAsync();
            return repertoire == null;
        }

        public async Task<Repertoire?> GetRepertoireByIdAsync(int id)
        {
            return await _context.Repertoires.FirstOrDefaultAsync(x => x.IdRepertoire == id);
        }
        public async Task DeleteRepertoireAsync(Repertoire repertoire)
        {
            _context.Repertoires.Remove(repertoire);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRepertoireAsync(Repertoire repertoire, UpdateRepertoireDTO updateRepertoireDTO)
        {
            repertoire.Date = DateOnly.FromDateTime((DateTime)updateRepertoireDTO.Date);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Movie>> GetMoviesFromRepertoireAsync(int id)
        {
            return await _context.MovieRepertoires.Where(x => x.IdRepertoire == id).Select(x => x.Movie).ToListAsync();
        }

    }
}
