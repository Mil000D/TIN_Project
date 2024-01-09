using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.Mappers.MoviesRepertoireMappers;
using TIN_Project.Server.Services.CinemasServices;
using TIN_Project.Server.Services.MoviesRepertoiresServices;
using TIN_Project.Server.Services.MoviesServices;
using TIN_Project.Server.Services.RepertoiresServices;
using TIN_Project.Shared.DTOs.MoviesRepertoireDTOs;

namespace TIN_Project.Server.Controllers.MoviesRepertoires
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesRepertoiresController : ControllerBase
    {
        private readonly IMoviesDbService _moviesDbService;
        private readonly IRepertoiresDbService _repertoiresDbService;
        private readonly ICinemasDbService _cinemasDbService;
        private readonly IMoviesRepertoiresDbService _moviesRepertoiresDbService;
        private readonly IMoviesRepertoireMapper _moviesRepertoireMapper;
        public MoviesRepertoiresController(IMoviesDbService moviesDbService, IRepertoiresDbService repertoiresDbService, ICinemasDbService cinemasDbService, IMoviesRepertoiresDbService moviesRepertoiresDbService, IMoviesRepertoireMapper moviesRepertoireMapper)
        {
            _moviesDbService = moviesDbService;
            _repertoiresDbService = repertoiresDbService;
            _cinemasDbService = cinemasDbService;
            _moviesRepertoiresDbService = moviesRepertoiresDbService;
            _moviesRepertoireMapper = moviesRepertoireMapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetMoviesRepertoiresAsync([FromQuery] int IdCinema, [FromQuery] int IdRepertoire)
        {
            var cinema = await _cinemasDbService.GetCinemaByIdAsync(IdCinema);
            var movies = await _repertoiresDbService.GetMoviesFromRepertoireAsync(IdRepertoire);
            var repertoire = await _repertoiresDbService.GetRepertoireByIdAsync(IdRepertoire);
            var moviesRepertoires = await _moviesRepertoiresDbService.GetMoviesRepertoiresByRepertoireIdAsync(IdRepertoire);
            if (cinema == null || movies == null || repertoire == null || moviesRepertoires == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_moviesRepertoireMapper.MapToGetMoviesRepertoireDTO(cinema, movies, repertoire, moviesRepertoires));
            }
        }
        [AllowAnonymous]
        [HttpGet("details")]
        public async Task<IActionResult> GetMovieDetailsAsync([FromQuery] int IdMovie, [FromQuery] int IdCinema, [FromQuery] int IdRepertoire)
        {
            var movie = await _moviesDbService.GetMovieByIdAsync(IdMovie);
            var cinema = await _cinemasDbService.GetCinemaByIdAsync(IdCinema);
            var repertoire = await _repertoiresDbService.GetRepertoireByIdAsync(IdRepertoire);
            var movieRepertoire = await _moviesRepertoiresDbService.GetMovieRepertoireByMovieAndRepertoireIdAsync(IdMovie, IdRepertoire);
            if (cinema == null || movie == null || repertoire == null || movieRepertoire == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_moviesRepertoireMapper.MapMovieToGetMovieDetailsDTO(movie, cinema, repertoire, movieRepertoire));
            }
        }
        [AllowAnonymous]
        [HttpGet("showtimes/{idRepertoire}")]
        public async Task<IActionResult> GetMoviesWithShowTimesAsync(int idRepertoire)
        {
            var moviesRepertoires = await _moviesRepertoiresDbService.GetMoviesRepertoiresByRepertoireIdAsync(idRepertoire);
			var movies = await _moviesDbService.GetMoviesByRepertoireIdAsync(idRepertoire);
			if (movies == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_moviesRepertoireMapper.MapMovieToGetMovieWithShowTimesDTOs(movies, moviesRepertoires));
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddMoviesRepertoireAsync([FromBody] AddMoviesRepertoireDTO addMoviesRepertoireDTO)
        {
            if (!await _moviesRepertoiresDbService.IsMovieShowTimeUniqueAsync(addMoviesRepertoireDTO))
            {
                return Conflict();
            }
            else
            {
				var moviesRepertoire = _moviesRepertoireMapper.MapAddMoviesRepertoireToMovieRepertoire(addMoviesRepertoireDTO);
				await _moviesRepertoiresDbService.AddMoviesRepertoireAsync(moviesRepertoire);
				return Ok();
			}
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoviesRepertoireAsync(int id)
        {
            var moviesRepertoire = await _moviesRepertoiresDbService.GetMoviesRepertoireByIdAsync(id);
            if (moviesRepertoire == null)
            {
                return NotFound();
            }
            else
            {
                await _moviesRepertoiresDbService.DeleteMoviesRepertoireAsync(moviesRepertoire);
                return Ok();
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMoviesRepertoireAsync([FromBody] UpdateMoviesRepertoireDTO updateMoviesRepertoireDTO)
        {
            var moviesRepertoire = await _moviesRepertoiresDbService.GetMoviesRepertoireByIdAsync(updateMoviesRepertoireDTO.IdMoviesRepertoire);
            if (moviesRepertoire == null)
            {
                return NotFound();
            }
            else if(!await _moviesRepertoiresDbService.IsMovieShowTimeUniqueAsync(updateMoviesRepertoireDTO))
            {
				return Conflict();
			}
            else
            {
                await _moviesRepertoiresDbService.UpdateMoviesRepertoireAsync(moviesRepertoire, updateMoviesRepertoireDTO);
                return Ok();
            }
        }
    }
}
