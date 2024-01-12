using TIN_Project.Server.Models;

namespace TIN_Project.Server.TokenManagers
{
    public interface ITokenManager
    {
        public Task GenerateTokensAsync(User user, HttpResponse httpResponse);
        public Task DeleteRefreshTokenAsync(User user, HttpResponse httpResponse);
    }
}
