using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.Enums;
using TIN_Project.Server.Mappers.UserMappers;
using TIN_Project.Server.Services.UsersServices;
using TIN_Project.Shared.DTOs.UserDTOs;

namespace TIN_Project.Server.Controllers.Users
{
    [Authorize(Roles = "Superuser")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersDbService _usersDbService;
        private readonly IUserMapper _mapper;
        public UsersController(IUsersDbService usersDbService, IUserMapper userMapper)
        {
            _usersDbService = usersDbService;
            _mapper = userMapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _usersDbService.GetAllUsersAsync();
            return Ok(_mapper.MapUsersToGetUserDTOs(users));
        }
        [HttpPost("admin")]
        public async Task<IActionResult> AddAdminAsync([FromBody] AddAdminDTO addAdminDTO)
        {
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == addAdminDTO.Username);
            if (user != null)
            {
                return Conflict();
            }
            else
            {
                var userFromDTO = _mapper.MapAddAdminDTOToUser(addAdminDTO, Role.Admin);
                await _usersDbService.AddUserAsync(userFromDTO);
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAsync(int id)
        {
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.IdUser == id && id != 1);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                await _usersDbService.DeleteUserAsync(user);
                return Ok();
            }
        }
    }
}
