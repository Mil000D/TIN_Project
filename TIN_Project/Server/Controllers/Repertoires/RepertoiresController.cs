using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.Mappers.RepertoireMappers;
using TIN_Project.Server.Models;
using TIN_Project.Server.Services.RepertoiresServices;
using TIN_Project.Shared.DTOs.RepertoireDTOs;

namespace TIN_Project.Server.Controllers.Repertoires
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class RepertoiresController : ControllerBase
    {
        private readonly IRepertoiresDbService _repertoiresDbService;
        private readonly IRepertoireMapper _repertoireMapper;
        public RepertoiresController(IRepertoiresDbService repertoiresDbService, IRepertoireMapper repertoireMapper)
        {
            _repertoiresDbService = repertoiresDbService;
            _repertoireMapper = repertoireMapper;
        }
        [AllowAnonymous]
        [HttpGet("{idCinema}")]
        public async Task<IActionResult> GetRepertoiresWithCinemaIdAsync(int idCinema)
        {
            var repertoires = await _repertoiresDbService.GetRepertoiresWithCinemaIdAsync(idCinema);
            return Ok(_repertoireMapper.MapRepertoiresToGetRepertoireDTOs(repertoires));
        }
        [HttpPost("{idCinema}")]
        public async Task<IActionResult> AddRepertoireAsync(int idCinema, [FromBody] AddRepertoireDTO addRepertoireDTO)
        {
            if (!await _repertoiresDbService.IsDateUniqueAsync(addRepertoireDTO))
            {
                return Conflict();
            }
            else
            {
                var repertoire = _repertoireMapper.MapAddRepertoireDTOToRepertoire(addRepertoireDTO);
                await _repertoiresDbService.AddRepertoireForCinemaAsync(idCinema, repertoire);
                return Ok();
            }
        }

        [HttpDelete("{idRepertoire}")]
        public async Task<IActionResult> DeleteRepertoireAsync(int idRepertoire)
        {
            var repertoire = await _repertoiresDbService.GetRepertoireByIdAsync(idRepertoire);
            if (repertoire == null)
            {
                return NotFound();
            }
            else
            {
                await _repertoiresDbService.DeleteRepertoireAsync(repertoire);
                return Ok();
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRepertoireAsync([FromBody] UpdateRepertoireDTO updateRepertoireDTO)
        {
            var repertoire = await _repertoiresDbService.GetRepertoireByIdAsync(updateRepertoireDTO.IdRepertoire);
            if (repertoire == null)
            {
                return NotFound();
            }
            else if(!await _repertoiresDbService.IsDateUniqueAsync(updateRepertoireDTO))
            {
                return Conflict();
            }
            else
            {
                await _repertoiresDbService.UpdateRepertoireAsync(repertoire, updateRepertoireDTO);
                return Ok();
            }
        }

    }
}
