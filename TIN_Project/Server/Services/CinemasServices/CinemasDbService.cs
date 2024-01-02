using TIN_Project.Server.Context;
using TIN_Project.Server.Models;
using Microsoft.EntityFrameworkCore;
using TIN_Project.Shared.DTOs.CinemaDTOs;

namespace TIN_Project.Server.Services.CinemasServices
{
    public class CinemasDbService : ICinemasDbService
    {
        private readonly MainDbContext _context;
        public CinemasDbService(MainDbContext context)
        {
            _context = context;
        }
        public async Task<List<Cinema>> GetCinemasAsync()
        {
            return await _context.Cinemas.OrderBy(c => c.Name).ToListAsync();
        }
        public async Task AddCinemaAsync(Cinema cinema)
        {
            _context.Cinemas.Add(cinema);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCinemaAsync(Cinema cinema)
        {
            _context.Cinemas.Remove(cinema);
            await _context.SaveChangesAsync();
        }

        public async Task<Cinema?> GetCinemaByIdAsync(int id)
        {
            return await _context.Cinemas.FirstOrDefaultAsync(c => c.IdCinema == id);
        }

        public async Task UpdateCinemaAsync(Cinema cinemaToUpdate, UpdateCinemaDTO cinemaDTO)
        {
            cinemaToUpdate.Name = cinemaDTO.Name;
            cinemaToUpdate.Address = cinemaDTO.Address;
            await _context.SaveChangesAsync();
        }

    }
}
