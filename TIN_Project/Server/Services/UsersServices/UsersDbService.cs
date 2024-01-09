using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TIN_Project.Server.Context;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.UserDTOs;
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
        public Task DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
            return _context.SaveChangesAsync();
        }
        public async Task UpdateUserAsync(GetUpdateUserProfileDTO userDTO, User user)
        {
            user.Username = userDTO.Username;
            user.Email = userDTO.Email;
            user.Name = userDTO.Name;
            user.Surname = userDTO.Surname;
            user.BirthDate = DateOnly.FromDateTime((DateTime)userDTO.BirthDate);
            await _context.SaveChangesAsync();
        }

        public Task UpdateUserPasswordAsync(User user, string newPassword)
        {
            user.Password = newPassword;
            return _context.SaveChangesAsync();
        }
    }
}
