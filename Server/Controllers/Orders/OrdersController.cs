using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TIN_Project.Server.Mappers.CinemaMappers;
using TIN_Project.Server.Mappers.OrderMappers;
using TIN_Project.Server.Services.CinemasServices;
using TIN_Project.Server.Services.MoviesRepertoiresServices;
using TIN_Project.Server.Services.MoviesServices;
using TIN_Project.Server.Services.OrdersServices;
using TIN_Project.Server.Services.RepertoiresServices;
using TIN_Project.Server.Services.UsersServices;
using TIN_Project.Shared.Base64Decoder;
using TIN_Project.Shared.DTOs.OrderDTOs;

namespace TIN_Project.Server.Controllers.Orders
{
    [Authorize(Roles = "Customer")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderMapper _orderMapper;
        private readonly IOrdersDbService _ordersDbService;
        private readonly IUsersDbService _usersDbService;
        private readonly IMoviesRepertoiresDbService _moviesRepertoiresDbService;
        private readonly IMoviesDbService _moviesDbService;
        private readonly ICinemasDbService _cinemasDbService;
        private readonly IRepertoiresDbService _repertoiresDbService;
        private readonly IDecoder _decoder;
        public OrdersController(IOrderMapper orderMapper, IOrdersDbService ordersDbService, IUsersDbService usersDbService, IMoviesRepertoiresDbService moviesRepertoiresDbService, IMoviesDbService moviesDbService, IRepertoiresDbService repertoiresDbService, ICinemasDbService cinemasDbService, IDecoder decoder)
        {
            _orderMapper = orderMapper;
            _ordersDbService = ordersDbService;
            _usersDbService = usersDbService;
            _moviesRepertoiresDbService = moviesRepertoiresDbService;
            _moviesDbService = moviesDbService;
            _repertoiresDbService = repertoiresDbService;
            _cinemasDbService = cinemasDbService;
            _decoder = decoder;
        }
        [HttpGet("{page}")]
        public async Task<IActionResult> GetOrdersAsync(int page)
        {
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == username);
            var orders = await _ordersDbService.GetAllOrdersByUserIdAsync(user.IdUser);
            var moviesRepertoires = await _moviesRepertoiresDbService.GetMoviesRepertoiresByOrdersAsync(orders);
            var movies = await _moviesDbService.GetMoviesByMoviesRepertoiresAsync(moviesRepertoires);
            var repertoires = await _repertoiresDbService.GetRepertoiresByMoviesRepertoiresAsync(moviesRepertoires);
            var cinemas = await _cinemasDbService.GetCinemasByRepertoiresAsync(repertoires);
            var getOrderDTOs = _orderMapper.MapToGetOrderDTOs(orders, movies, moviesRepertoires, cinemas, repertoires);
            int pageSize = 2;
            var paginatedOrderDTOs = getOrderDTOs.Skip(page * pageSize)
                                                  .Take(pageSize)
                                                  .ToList();
            return Ok(paginatedOrderDTOs);
        }
        [HttpGet("count")]
        public async Task<IActionResult> GetOrdersCountAsync()
        {
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == username);
            var orders = await _ordersDbService.GetAllOrdersByUserIdAsync(user.IdUser);
            return Ok(Math.Ceiling((double)orders.Count/2));
        }
        [HttpPut("{idMovieRepertoire}")]
        public async Task<IActionResult> UpdateOrderAsync(int idMovieRepertoire)
        {
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var order = await _ordersDbService.GetOrderByMovieRepertoireIdAsync(idMovieRepertoire);
            if (order == null)
            {
                return NotFound();
            }
            else
            {
                await _ordersDbService.UpdateOrderAsync(order);
                return Ok();
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddOrderAsync([FromBody] AddOrderDTO addOrderDTO)
        {
            Request.Cookies.TryGetValue("payload", out var token);
            var tokenString = _decoder.DecodeBase64Url(token);
            var username = _decoder.GetUsernameFromToken(tokenString);
            var order = await _ordersDbService.GetOrderByMovieRepertoireIdAsync(addOrderDTO.IdMovieRepertoire);
            if(order != null)
            {
                return Conflict();
            }
            else
            {
                var user = await _usersDbService.GetUserByPredicateAsync(x => x.Username == username);
                var newOrder = _orderMapper.MapAddOrderDTOToOrder(addOrderDTO, user.IdUser);
                await _ordersDbService.AddOrderAsync(newOrder);
                return Ok();
            }
        }
    }
}
