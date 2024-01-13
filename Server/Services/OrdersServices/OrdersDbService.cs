using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Context;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Services.OrdersServices
{
    public class OrdersDbService : IOrdersDbService
    {
        private readonly MainDbContext _context;
        public OrdersDbService(MainDbContext context)
        {
            _context = context;
        }
        public async Task<Order?> GetOrderByMovieRepertoireIdAsync(int idMovieRepertoire, int idUser)
        {
            return await _context.Orders.FirstOrDefaultAsync(o => o.IdMovieRepertoire == idMovieRepertoire && o.IdUser == idUser);
        }
        public async Task AddOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllOrdersByUserIdAsync(int idUser)
        {
            return await _context.Orders.Where(o => o.IdUser == idUser).ToListAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            order.IsPaid = true;
            await _context.SaveChangesAsync();
        }
    }
}
