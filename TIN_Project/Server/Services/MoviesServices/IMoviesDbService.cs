using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.MovieDTOs;

namespace TIN_Project.Server.Services.MoviesServices
{
    public interface IMoviesDbService
    {
        public Task<List<Movie>> GetMoviesAsync();
        public Task<Movie> GetMovieByIdAsync(int id);
        public Task<List<Movie>> GetMoviesByRepertoireIdAsync(int idRepertoire);
		public Task DeleteMovieAsync(Movie movie);
        public Task UpdateMovieAsync(Movie movieToUpdate, UpdateMovieDTO movieDTO);
        public Task AddMovieAsync(Movie movie, AddMovieDTO addMovieDTO);
    }
}
