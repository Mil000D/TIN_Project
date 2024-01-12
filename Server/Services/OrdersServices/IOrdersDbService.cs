using TIN_Project.Server.Models;

namespace TIN_Project.Server.Services.OrdersServices
{
    public interface IOrdersDbService
    {
        public Task<Order?> GetOrderByMovieRepertoireIdAsync(int idMovieRepertoire);
        public Task AddOrderAsync(Order order);
        public Task<List<Order>> GetAllOrdersByUserIdAsync(int idUser);
        public Task UpdateOrderAsync(Order order);
    }
}
