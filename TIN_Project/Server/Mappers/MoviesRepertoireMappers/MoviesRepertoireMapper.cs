using TIN_Project.Server.Mappers.GenreMappers;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.MovieDTOs;
using TIN_Project.Shared.DTOs.MoviesRepertoireDTOs;

namespace TIN_Project.Server.Mappers.MoviesRepertoireMappers
{
    public class MoviesRepertoireMapper : IMoviesRepertoireMapper
    {
        private readonly IGenreMapper _genreMapper;
        public MoviesRepertoireMapper(IGenreMapper genreMapper)
        {
            _genreMapper = genreMapper;
        }
        public List<GetMoviesRepertoireDTO> MapToGetMoviesRepertoireDTO(Cinema cinema, List<Movie> movies, Repertoire repertoire, List<MovieRepertoire> movieRepertoirs)
        {
            return movieRepertoirs.Select(movieRepertoire => new GetMoviesRepertoireDTO
            {
                IdMoviesRepertoire = movieRepertoire.IdMovieRepertoire,
                IdMovie = movieRepertoire.IdMovie,
                PosterUrl = movies.Where(movie => movie.IdMovie == movieRepertoire.IdMovie).Select(movie => movie.PosterUrl).FirstOrDefault(),
                Title = movies.Where(movie => movie.IdMovie == movieRepertoire.IdMovie).Select(movie => movie.EnglishTitle).FirstOrDefault(),
                Date = repertoire.Date.ToDateTime(TimeOnly.Parse("0:00")),
                ShowTime = movieRepertoire.ShowTime,
                CinemaName = cinema.Name,
                CinemaAddress = cinema.Address
            }).OrderBy(x => x.ShowTime).ToList();
        }

        public MovieRepertoire MapAddMoviesRepertoireToMovieRepertoire(AddMoviesRepertoireDTO addMoviesRepertoireDTO)
        {
            return new MovieRepertoire
            {
                IdMovie = addMoviesRepertoireDTO.IdMovie,
                IdRepertoire = addMoviesRepertoireDTO.IdRepertoire,
                ShowTime = addMoviesRepertoireDTO.ShowTime
            };
        }
        public GetMovieDetailsDTO MapMovieToGetMovieDetailsDTO(Movie movie, Cinema cinema, Repertoire repertoire, MovieRepertoire movieRepertoire)
        {
            return new GetMovieDetailsDTO
            {
                IdMovie = movie.IdMovie,
                IdMovieRepertoire = movieRepertoire.IdMovieRepertoire,
                Title = movie.EnglishTitle,
                Description = movie.EnglishDescription,
                TrailerUrl = movie.TrailerUrl,
                PosterUrl = movie.PosterUrl,
                Genres = _genreMapper.MapGenresToGenreDTOs(movie.Genres),
                CinemaName = cinema.Name,
                CinemaAddress = cinema.Address,
                Date = repertoire.Date,
                ShowTime = movieRepertoire.ShowTime
            };
        }

        public List<GetMovieWithShowTimesDTO> MapMovieToGetMovieWithShowTimesDTOs(List<Movie> movies, List<MovieRepertoire> movieRepertoires)
        {
            return movies.Select(movie => new GetMovieWithShowTimesDTO
            {
                IdMovie = movie.IdMovie,
                Title = movie.EnglishTitle,
                PosterUrl = movie.PosterUrl,
                Genres = _genreMapper.MapGenresToGenreDTOs(movie.Genres),
                ShowTimes = movieRepertoires.OrderBy(mr => mr.ShowTime).Where(movieRepertoire => movieRepertoire.IdMovie == movie.IdMovie).Select(movieRepertoire => movieRepertoire.ShowTime).ToList()
            }).ToList();
        }
    }
}
