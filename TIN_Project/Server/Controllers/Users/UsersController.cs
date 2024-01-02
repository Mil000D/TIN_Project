using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.Mappers.UserMappers;
using TIN_Project.Server.Services.UsersServices;

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
    }
}
