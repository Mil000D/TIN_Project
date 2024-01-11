using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using TIN_Project.Server.Services.UsersServices;
using TIN_Project.Server.TokenManagers;

namespace TIN_Project.Server.Middlewares
{
    public class TokenRefreshMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenRefreshMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var userDbService = context.RequestServices.GetRequiredService<IUsersDbService>();
            var tokenManager = context.RequestServices.GetRequiredService<ITokenManager>();

            var accessTokenValidationResult = await context.AuthenticateAsync(JwtBearerDefaults.AuthenticationScheme);

            if (accessTokenValidationResult.Succeeded)
            {
                await _next(context);
                return;
            }

            if (context.Request.Cookies.TryGetValue("refreshToken", out string? refreshToken))
            {
                var user = await userDbService.GetUserByPredicateAsync(x => x.RefreshToken == refreshToken && x.RefreshTokenExpirationDate >= DateTime.Now);

                if (user != null)
                {
                    var httpResponse = context.Response;
                    await tokenManager.GenerateTokensAsync(user, httpResponse);
                }
            }

            await _next(context);
        }
    }
}