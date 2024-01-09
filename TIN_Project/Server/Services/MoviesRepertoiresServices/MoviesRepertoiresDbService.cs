using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Context;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.MoviesRepertoireDTOs;

namespace TIN_Project.Server.Services.MoviesRepertoiresServices
{
    public class MoviesRepertoiresDbService : IMoviesRepertoiresDbService
    {
        private MainDbContext _context;
        public MoviesRepertoiresDbService(MainDbContext context)
        {
            _context = context;
        }

        public async Task<List<MovieRepertoire>> GetMoviesRepertoiresByRepertoireIdAsync(int idRepertoire)
        {
            return await _context.MovieRepertoires.Where(x => x.IdRepertoire == idRepertoire).ToListAsync();
        }
        public async Task<List<MovieRepertoire>> GetMoviesRepertoiresByOrdersAsync(List<Order> orders)
        {
            var moviesRepertoires = new List<MovieRepertoire>();
            foreach (var order in orders)
            {
                var movieRepertoire = await _context.MovieRepertoires.FirstOrDefaultAsync(x => x.IdMovieRepertoire == order.IdMovieRepertoire);
                if (movieRepertoire != null)
                {
                    moviesRepertoires.Add(movieRepertoire);
                }
            }
            return moviesRepertoires;
        }
       
        public async Task<MovieRepertoire?> GetMovieRepertoireByMovieAndRepertoireIdAsync(int idMovie, int idRepertoire)
        {
            return await _context.MovieRepertoires.FirstOrDefaultAsync(x => x.IdMovie == idMovie && x.IdRepertoire == idRepertoire);
        }

        public async Task AddMoviesRepertoireAsync(MovieRepertoire movieRepertoire)
        {
            await _context.MovieRepertoires.AddAsync(movieRepertoire);
            await _context.SaveChangesAsync();
        }

        public async Task<MovieRepertoire?> GetMoviesRepertoireByIdAsync(int id)
        {
           return await _context.MovieRepertoires.FirstOrDefaultAsync(x => x.IdMovieRepertoire == id);
        }

        public async Task DeleteMoviesRepertoireAsync(MovieRepertoire movieRepertoire)
        {
            _context.MovieRepertoires.Remove(movieRepertoire);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateMoviesRepertoireAsync(MovieRepertoire moviesRepertoire, UpdateMoviesRepertoireDTO updateMoviesRepertoireDTO)
        {
            moviesRepertoire.IdMovie = updateMoviesRepertoireDTO.IdMovie;
            moviesRepertoire.ShowTime = updateMoviesRepertoireDTO.ShowTime;
            await _context.SaveChangesAsync();
        }
		public async Task<bool> IsMovieShowTimeUniqueAsync(AddMoviesRepertoireDTO addMoviesRepertoireDTO)
        {
            var movieRepertoire = await _context.MovieRepertoires.FirstOrDefaultAsync(x => x.IdMovie == addMoviesRepertoireDTO.IdMovie && x.IdRepertoire == addMoviesRepertoireDTO.IdRepertoire && x.ShowTime == addMoviesRepertoireDTO.ShowTime);
            return movieRepertoire == null;
		}
		public async Task<bool> IsMovieShowTimeUniqueAsync(UpdateMoviesRepertoireDTO updateMoviesRepertoireDTO)
        { 
			var movieRepertoire = await _context.MovieRepertoires.FirstOrDefaultAsync(x => x.IdMovie == updateMoviesRepertoireDTO.IdMovie && x.IdRepertoire == updateMoviesRepertoireDTO.IdRepertoire && x.ShowTime == updateMoviesRepertoireDTO.ShowTime && x.IdMovieRepertoire != updateMoviesRepertoireDTO.IdMoviesRepertoire);
			return movieRepertoire == null;
		}

	}
}
