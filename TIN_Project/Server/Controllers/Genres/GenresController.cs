using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.Mappers.GenreMappers;
using TIN_Project.Server.Services.GenresServices;
using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Server.Controllers.Genres
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenresDbService _genresDbService;
        private readonly IGenreMapper _genreMapper;
        public GenresController(IGenresDbService genresDbService, IGenreMapper genreMapper)
        {
            _genresDbService = genresDbService;
            _genreMapper = genreMapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddGenreAsync([FromBody] GenreDTO genreDTO)
        {
            if (!await _genresDbService.IsNameUniqueAsync(genreDTO))
            {
                return Conflict();
            }
            else
            {
                await _genresDbService.AddGenreAsync(genreDTO);
                return Ok();
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetGenresAsync()
        {
            var genres = await _genresDbService.GetGenresAsync();
            return Ok(_genreMapper.MapGenresToGenreDTOs(genres));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGenreAsync([FromBody] GenreDTO genreDTO)
        {
            var genre = await _genresDbService.GetGenreByIdAsync(genreDTO.IdGenre);
            if (genre == null)
            {
                return NotFound();
            }
            else if (!await _genresDbService.IsNameUniqueAsync(genreDTO))
            {
                return Conflict();
            }
            else
            {
                await _genresDbService.UpdateGenreAsync(genre, genreDTO);
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenreAsync(int id)
        {
            var genre = await _genresDbService.GetGenreByIdAsync(id);
            if(genre == null)
            {
                return NotFound();
            }
            await _genresDbService.DeleteGenreAsync(genre);
            return Ok();
        }
    }
}
