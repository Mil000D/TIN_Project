using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.MovieDTOs;
using TIN_Project.Shared.DTOs.MoviesRepertoireDTOs;

namespace TIN_Project.Server.Mappers.MoviesRepertoireMappers
{
    public interface IMoviesRepertoireMapper
    {
        public List<GetMoviesRepertoireDTO> MapToGetMoviesRepertoireDTO(Cinema cinema, List<Movie> movies, Repertoire repertoire, List<MovieRepertoire> movieRepertoirs, string culture);
        public MovieRepertoire MapAddMoviesRepertoireToMovieRepertoire(AddMoviesRepertoireDTO addMoviesRepertoireDTO);
        public GetMovieDetailsDTO MapMovieToGetMovieDetailsDTO(Movie movie, Cinema cinema, Repertoire repertoire, MovieRepertoire movieRepertoire, string culture);
        public List<GetMovieWithShowTimesDTO> MapMovieToGetMovieWithShowTimesDTOs(List<Movie> movies, List<MovieRepertoire> movieRepertoires, string culture);
    }
}
