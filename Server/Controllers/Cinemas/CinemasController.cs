using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.Mappers.CinemaMappers;
using TIN_Project.Server.Services.CinemasServices;
using TIN_Project.Shared.DTOs.CinemaDTOs;

namespace TIN_Project.Server.Controllers.Cinemas
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly ICinemasDbService _cinemasDbService;
        private readonly ICinemaMapper _cinemaMapper;
        public CinemasController(ICinemasDbService cinemasDbService, ICinemaMapper cinemaMapper)
        {
            _cinemasDbService = cinemasDbService;
            _cinemaMapper = cinemaMapper;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetCinemasAsync()
        {
            var cinemas = await _cinemasDbService.GetCinemasAsync();
            return Ok(_cinemaMapper.MapCinemasToGetCinemaDTOs(cinemas));
        }

        [HttpPost]
        public async Task<IActionResult> AddCinemaAsync([FromBody] AddCinemaDTO addCinemaDTO)
        {
            var cinema = _cinemaMapper.MapAddCinemaDTOToCinema(addCinemaDTO);
            await _cinemasDbService.AddCinemaAsync(cinema);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCinemaAsync(int id)
        {
            var cinema = await _cinemasDbService.GetCinemaByIdAsync(id);
            if (cinema == null)
            {
                return NotFound();
            }
            else
            {
                await _cinemasDbService.DeleteCinemaAsync(cinema);
                return Ok();
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCinemaAsync([FromBody] UpdateCinemaDTO updateCinemaDTO)
        {
            var cinema = await _cinemasDbService.GetCinemaByIdAsync(updateCinemaDTO.IdCinema);
            if (cinema == null)
            {
                return NotFound();
            }
            else
            {
                await _cinemasDbService.UpdateCinemaAsync(cinema, updateCinemaDTO);
                return Ok();
            }
        }
    }
}
