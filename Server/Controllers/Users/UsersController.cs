using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using TIN_Project.Server.Enums;
using TIN_Project.Server.Mappers.UserMappers;
using TIN_Project.Server.Services.UsersServices;
using TIN_Project.Shared.Base64Decoder;
using TIN_Project.Shared.DTOs.UserDTOs;

namespace TIN_Project.Server.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersDbService _usersDbService;
        private readonly IUserMapper _mapper;
        private readonly IDecoder _decoder;
        public UsersController(IUsersDbService usersDbService, IUserMapper userMapper, IDecoder decoder)
        {
            _usersDbService = usersDbService;
            _mapper = userMapper;
            _decoder = decoder;
        }
        [Authorize(Roles = "Superuser")]
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _usersDbService.GetAllUsersAsync();
            return Ok(_mapper.MapUsersToGetUserDTOs(users));
        }
        [Authorize(Roles = "Admin, Customer")]
        [HttpGet("profile")]
        public async Task<IActionResult> GetProfileAsync()
        {
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == username);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.MapUserToGetUpdateUserProfileDTO(user));
            }
        }
        [Authorize(Roles = "Admin, Customer")]
        [HttpPut("profile")]
        public async Task<IActionResult> UpdateProfileAsync([FromBody] GetUpdateUserProfileDTO userDTO)
        {
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == username);
            if (user == null)
            {
                return NotFound();
            }
            else if(await _usersDbService.GetUserByPredicateAsync(x => x.Username == userDTO.Username && x.IdUser != user.IdUser) != null)
            {
                return Conflict();
            }
            else
            {
                await _usersDbService.UpdateUserAsync(userDTO, user);
                return Ok();
            }
        }
        [Authorize(Roles = "Admin, Customer")]
        [HttpPut("profile/password")]
        public async Task<IActionResult> UpdatePasswordAsync([FromBody] UpdateUserPasswordDTO updatePasswordDTO)
        {
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == username);
            if (user == null)
            {
                return NotFound();
            }
            else if(user.Password != updatePasswordDTO.OldPassword)
            {
                return BadRequest();
            }
            else if(user.Password == updatePasswordDTO.NewPassword)
            {
                return Conflict();
            }
            else
            {
                await _usersDbService.UpdateUserPasswordAsync(user, updatePasswordDTO.NewPassword);
                return Ok();
            }
        }
        [Authorize(Roles = "Superuser")]
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
        [Authorize(Roles = "Superuser")]
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
