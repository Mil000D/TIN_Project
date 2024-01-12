using TIN_Project.Server.Mappers.GenreMappers;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.MovieDTOs;


namespace TIN_Project.Server.Mappers.MovieMappers
{
    public class MovieMapper : IMovieMapper
    {
        private readonly IGenreMapper _genreMapper;
        public MovieMapper(IGenreMapper genreMapper)
        {
            _genreMapper = genreMapper;
        }
        public List<GetMovieDTO> MapMoviesToGetMovieDTOs(List<Movie> movies, string culture)
        {
            return movies.Select(movie => new GetMovieDTO
            {
                IdMovie = movie.IdMovie,
                Title = culture == "en-US" ? movie.EnglishTitle : movie.PolishTitle,
                PosterUrl = movie.PosterUrl,
                TrailerUrl = movie.TrailerUrl,
                Genres = _genreMapper.MapGenresToGenreDTOs(movie.Genres)
            }).ToList();
        }
        public UpdateMovieDTO MapMovieToUpdateMovieDTO(Movie movie)
        {
            return new UpdateMovieDTO
            {
                IdMovie = movie.IdMovie,
                EnglishTitle = movie.EnglishTitle,
                PolishTitle = movie.PolishTitle,
                EnglishDescription = movie.EnglishDescription,
                PolishDescription = movie.PolishDescription,
                TrailerUrl = movie.TrailerUrl,
                PosterUrl = movie.PosterUrl,
                Genres = _genreMapper.MapGenresToGenreDTOs(movie.Genres)
            };
        }
        public Movie MapAddMovieDTOToMovie(AddMovieDTO addMovieDTO)
        {
            return new Movie
            {
                EnglishTitle = addMovieDTO.EnglishTitle,
                PolishTitle = addMovieDTO.PolishTitle,
                EnglishDescription = addMovieDTO.EnglishDescription,
                PolishDescription = addMovieDTO.PolishDescription,
                TrailerUrl = addMovieDTO.TrailerUrl,
                PosterUrl = addMovieDTO.PosterUrl,
                Genres = new List<Genre>()
            };
        }
        
    }
}
