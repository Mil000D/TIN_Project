using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Context;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.MovieDTOs;

namespace TIN_Project.Server.Services.MoviesServices
{
    public class MoviesDbService : IMoviesDbService
    {
        private readonly MainDbContext _context;
        public MoviesDbService(MainDbContext context) 
        { 
            _context = context;
        }

        public async Task<List<Movie>> GetMoviesAsync()
        {
            return await _context.Movies.Include(m => m.Genres).OrderBy(m => m.EnglishTitle).ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.Include(m => m.Genres).FirstOrDefaultAsync(m => m.IdMovie == id);
        }
		public async Task<List<Movie>> GetMoviesByRepertoireIdAsync(int idRepertoire)
        {
            return await _context.Movies.Include(m => m.Genres).Where(m => m.MovieRepertoires.Any(mr => mr.IdRepertoire == idRepertoire)).ToListAsync();
        }
        public async Task<List<Movie>> GetMoviesByMoviesRepertoiresAsync(List<MovieRepertoire> movieRepertoires)
        {
            var movies = new List<Movie>();
            foreach (var movieRepertoire in movieRepertoires)
            {
                var movie = await _context.Movies.FirstOrDefaultAsync(x => x.IdMovie == movieRepertoire.IdMovie);
                if (movie != null)
                {
                    movies.Add(movie);
                }
            }
            return movies;
        }
        public async Task DeleteMovieAsync(Movie movie)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(Movie movieToUpdate, UpdateMovieDTO movieDTO)
        {
            movieToUpdate.EnglishTitle = movieDTO.EnglishTitle;
            movieToUpdate.PolishTitle = movieDTO.PolishTitle;
            movieToUpdate.EnglishDescription = movieDTO.EnglishDescription;
            movieToUpdate.PolishDescription = movieDTO.PolishDescription;
            movieToUpdate.TrailerUrl = movieDTO.TrailerUrl;
            movieToUpdate.PosterUrl = movieDTO.PosterUrl;
            foreach (var genre in _context.Genres)
            {
                if (movieDTO.Genres.Any(g => g.IdGenre == genre.IdGenre))
                {
                    if (!movieToUpdate.Genres.Contains(genre))
                    {
                        movieToUpdate.Genres.Add(genre);
                    }
                }
                else
                {
                    if (movieToUpdate.Genres.Contains(genre))
                    {
                        movieToUpdate.Genres.Remove(genre);
                    }
                }
            }
            await _context.SaveChangesAsync();
        }

        public async Task AddMovieAsync(Movie movie, AddMovieDTO addMovieDTO)
        {
            foreach (var genre in _context.Genres)
            {
                if(addMovieDTO.Genres.Any(g => g.IdGenre == genre.IdGenre))
                {
                    movie.Genres.Add(genre);
                }
            }
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }
    }
}
