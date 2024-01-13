using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.TokenManagers;
using TIN_Project.Server.Mappers.UserMappers;
using TIN_Project.Server.Enums;
using Microsoft.AspNetCore.Authorization;
using TIN_Project.Server.Services.UsersServices;
using TIN_Project.Shared.DTOs.UserDTOs;
using TIN_Project.Shared.Base64Decoder;

namespace TIN_Project.Server.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ITokenManager _tokenManager;
        private readonly IUsersDbService _usersDbService;
        private readonly IUserMapper _userMapper;
        private readonly IDecoder _decoder;
        public AuthenticationController(ITokenManager tokenManager, IUsersDbService userDbService, IUserMapper userMapper, IDecoder decoder)
        {
            _tokenManager = tokenManager;
            _usersDbService = userDbService;
            _userMapper = userMapper;
            _decoder = decoder;
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginUserDTO loginUserDTO)
        {
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == loginUserDTO.Username && x.Password == loginUserDTO.Password);
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
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == registerUserDTO.Username);
            if(user != null)
            {
                return Conflict();
            }            
            else
            {
                var userFromDTO = _userMapper.MapRegisterUserDTOToUser(registerUserDTO, Role.Customer);
                await _usersDbService.AddUserAsync(userFromDTO);
                await _tokenManager.GenerateTokensAsync(userFromDTO, Response);
                return Ok();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetTokensAsync()
        {
            Request.Cookies.TryGetValue("refreshToken", out string? refreshToken);
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.RefreshToken == refreshToken && x.RefreshTokenExpirationDate >= DateTime.Now);
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
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == username);
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
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == username);
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
