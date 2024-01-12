using System.Linq.Expressions;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.UserDTOs;
namespace TIN_Project.Server.Services.UsersServices
{
    public interface IUsersDbService
    {
        public Task AddUserAsync(User user);
        public Task<User?> GetUserByPredicateAsync(Expression<Func<User, bool>> predicate);
        public Task<List<User>> GetAllUsersAsync();
        public Task DeleteUserAsync(User user);
        public Task UpdateUserAsync(GetUpdateUserProfileDTO userDTO, User user);
        public Task UpdateUserPasswordAsync(User user, string newPassword);
    }
}
