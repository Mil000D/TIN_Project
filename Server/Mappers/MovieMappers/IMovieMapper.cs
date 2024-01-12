using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.MovieDTOs;

namespace TIN_Project.Server.Mappers.MovieMappers
{
    public interface IMovieMapper
    {
        public List<GetMovieDTO> MapMoviesToGetMovieDTOs(List<Movie> movies, string culture);
        public UpdateMovieDTO MapMovieToUpdateMovieDTO(Movie movie);
        public Movie MapAddMovieDTOToMovie(AddMovieDTO addMovieDTO);


    }
}
