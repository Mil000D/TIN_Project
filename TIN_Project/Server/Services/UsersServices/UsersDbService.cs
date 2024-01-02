using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TIN_Project.Server.Context;
using TIN_Project.Server.Models;
namespace TIN_Project.Server.Services.UsersServices
{
    public class UsersDbService : IUsersDbService
    {
        private readonly MainDbContext _context;
        public UsersDbService(MainDbContext context)
        {
            _context = context;
        }
        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetUserByPredicateAsync(Expression<Func<User, bool>> predicate)
        {
            return await _context.Users.FirstOrDefaultAsync(predicate);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users.Where(u => u.IdUser != 1).ToListAsync();
        }
    }
}
