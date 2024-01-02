using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.Mappers.MovieMappers;
using TIN_Project.Server.Services.MoviesServices;
using TIN_Project.Shared.DTOs.MovieDTOs;

namespace TIN_Project.Server.Controllers.Movies
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesDbService _moviesDbService;
        private readonly IMovieMapper _movieMapper;
        public MoviesController(IMoviesDbService moviesDbService, IMovieMapper movieMapper)
        {
            _moviesDbService = moviesDbService;
            _movieMapper = movieMapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetMoviesAsync()
        {
            var movies = await _moviesDbService.GetMoviesAsync();
            return Ok(_movieMapper.MapMoviesToGetMovieDTOs(movies));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieAsync(int id)
        {
            var movie = await _moviesDbService.GetMovieByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_movieMapper.MapMovieToUpdateMovieDTO(movie));
            }
        }

        [AllowAnonymous]
        [HttpGet("repertoire/{idRepertoire}")]
        public async Task<IActionResult> GetMoviesByRepertoireIdAsync(int idRepertoire)
        {
			var movies = await _moviesDbService.GetMoviesByRepertoireIdAsync(idRepertoire);
			return Ok(_movieMapper.MapMoviesToGetMovieDTOs(movies));
		}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieAsync(int id)
        {
            var movie = await _moviesDbService.GetMovieByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                await _moviesDbService.DeleteMovieAsync(movie);
                return Ok();
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMovieAsync([FromBody] UpdateMovieDTO updateMovieDTO)
        {
            var movie = await _moviesDbService.GetMovieByIdAsync(updateMovieDTO.IdMovie);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                await _moviesDbService.UpdateMovieAsync(movie, updateMovieDTO);
                return Ok();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddMovieAsync([FromBody] AddMovieDTO addMovieDTO)
        {
            var movie = _movieMapper.MapAddMovieDTOToMovie(addMovieDTO);
            await _moviesDbService.AddMovieAsync(movie, addMovieDTO);
            return Ok();
        }
    }
}
