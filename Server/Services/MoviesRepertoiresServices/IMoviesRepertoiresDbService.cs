using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.MoviesRepertoireDTOs;

namespace TIN_Project.Server.Services.MoviesRepertoiresServices
{
    public interface IMoviesRepertoiresDbService
    {
        public Task<List<MovieRepertoire>> GetMoviesRepertoiresByRepertoireIdAsync(int idRepertoire);
        public Task<List<MovieRepertoire>> GetMoviesRepertoiresByOrdersAsync(List<Order> orders);
        public Task<MovieRepertoire?> GetMovieRepertoireByMovieAndRepertoireIdAsync(int idMovie, int idRepertoire);
        public Task AddMoviesRepertoireAsync(MovieRepertoire movieRepertoire);
        public Task<MovieRepertoire?> GetMoviesRepertoireByIdAsync(int id);
        public Task DeleteMoviesRepertoireAsync(MovieRepertoire movieRepertoire);
        public Task UpdateMoviesRepertoireAsync(MovieRepertoire moviesRepertoire, UpdateMoviesRepertoireDTO updateMoviesRepertoireDTO);
        public Task<bool> IsMovieShowTimeUniqueAsync(AddMoviesRepertoireDTO addMoviesRepertoireDTO);
		public Task<bool> IsMovieShowTimeUniqueAsync(UpdateMoviesRepertoireDTO updateMoviesRepertoireDTO);
	}
}
