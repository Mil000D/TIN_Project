using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.CinemaDTOs;

namespace TIN_Project.Server.Services.CinemasServices
{
    public interface ICinemasDbService
    {
        public Task<List<Cinema>> GetCinemasAsync();
        public Task AddCinemaAsync(Cinema cinema);
        public Task DeleteCinemaAsync(Cinema cinema);
        public Task<Cinema?> GetCinemaByIdAsync(int id);
        public Task UpdateCinemaAsync(Cinema cinemaToUpdate, UpdateCinemaDTO cinemaDTO);

    }
}
