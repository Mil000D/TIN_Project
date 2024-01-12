using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.TokenManagers;
using TIN_Project.Server.Mappers.UserMappers;
using TIN_Project.Server.Enums;
using Microsoft.AspNetCore.Authorization;
using TIN_Project.Server.Services.UsersServices;
using TIN_Project.Shared.DTOs.UserDTOs;

namespace TIN_Project.Server.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ITokenManager _tokenManager;
        private readonly IUsersDbService _userDbService;
        private readonly IUserMapper _userMapper;
        public AuthenticationController(ITokenManager tokenManager, IUsersDbService userDbService, IUserMapper userMapper)
        {
            _tokenManager = tokenManager;
            _userDbService = userDbService;
            _userMapper = userMapper;
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginUserDTO loginUserDTO)
        {
            var user = await _userDbService.GetUserByPredicateAsync(x => x.Username == loginUserDTO.Username && x.Password == loginUserDTO.Password);
            if(user != null)
            {
                await _tokenManager.GenerateTokensAsync(user, Response);
                return Ok();
            }
            else
            {
                return NotFound();
            }
            
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterUserDTO registerUserDTO)
        {
            var user = await _userDbService.GetUserByPredicateAsync(x => x.Username == registerUserDTO.Username);
            if(user != null)
            {
                return Conflict();
            }            
            else
            {
                var userFromDTO = _userMapper.MapRegisterUserDTOToUser(registerUserDTO, Role.Customer);
                await _userDbService.AddUserAsync(userFromDTO);
                await _tokenManager.GenerateTokensAsync(userFromDTO, Response);
                return Ok();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetTokensAsync()
        {
            Request.Cookies.TryGetValue("refreshToken", out string? refreshToken);
            var user = await _userDbService.GetUserByPredicateAsync(x => x.RefreshToken == refreshToken && x.RefreshTokenExpirationDate >= DateTime.Now);
            if (user == null)
            {
                return Unauthorized();
            }
            else
            {
                var httpResponse = Response;
                await _tokenManager.GenerateTokensAsync(user, httpResponse);
                return Ok();
            }
        }
        [Authorize(Roles = "Admin, Customer")]
        [HttpGet("refresh")]
        public async Task<IActionResult> RefreshTokens()
        {
            Request.Cookies.TryGetValue("refreshToken", out string? refreshToken);
            var user = await _userDbService.GetUserByPredicateAsync(x => x.RefreshToken == refreshToken && x.RefreshTokenExpirationDate >= DateTime.Now);
            if (user == null)
            {
                return Unauthorized();
            }
            else
            {
                var httpResponse = Response;
                await _tokenManager.GenerateTokensAsync(user, httpResponse);
                return Ok();
            }
        }

        [Authorize(Roles = "Admin, Customer")]
        [HttpPost("logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            Request.Cookies.TryGetValue("refreshToken", out string? refreshToken);
            var user = await _userDbService.GetUserByPredicateAsync(x => x.RefreshToken.Equals(refreshToken) && x.RefreshTokenExpirationDate >= DateTime.Now);
            if (user == null)
            {
                return Unauthorized();
            }
            else
            {
                await _tokenManager.DeleteRefreshTokenAsync(user, Response);
                return Ok();
            }
        }
    }
}
