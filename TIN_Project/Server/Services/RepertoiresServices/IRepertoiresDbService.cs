using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.RepertoireDTOs;

namespace TIN_Project.Server.Services.RepertoiresServices
{
    public interface IRepertoiresDbService
    {
        public Task<List<Repertoire>> GetRepertoiresWithCinemaIdAsync(int id);
        public Task AddRepertoireForCinema(int idCinema, Repertoire repertoire);
        public Task<bool> IsDateUniqueAsync(AddRepertoireDTO addRepertoireDTO);
        public Task<bool> IsDateUniqueAsync(UpdateRepertoireDTO updateRepertoireDTO);
        public Task<Repertoire?> GetRepertoireByIdAsync(int id);
        public Task DeleteRepertoireAsync(Repertoire repertoire);
        public Task UpdateRepertoireAsync(Repertoire repertoire, UpdateRepertoireDTO updateRepertoireDTO);
        public Task<List<Movie>> GetMoviesFromRepertoireAsync(int id);

    }
}
