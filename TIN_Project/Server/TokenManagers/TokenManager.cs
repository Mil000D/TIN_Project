using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TIN_Project.Server.Models;
using TIN_Project.Server.Context;
using TIN_Project.Server.Enums;
using System.Data;

namespace TIN_Project.Server.TokenManagers
{
    public class TokenManager : ITokenManager
    {
        private readonly IConfiguration _configuration;
        private readonly MainDbContext _context;
        public TokenManager(IConfiguration configuration, MainDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        public async Task GenerateTokensAsync(User user, HttpResponse httpResponse)
        {
            user.RefreshToken = Guid.NewGuid().ToString();
            user.RefreshTokenExpirationDate = DateTime.Now.AddDays(1);
            await _context.SaveChangesAsync();
            Claim[] claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            if(user.Role == Role.Superuser)
            {
                claims = new[] { new Claim(ClaimTypes.Name, user.Username),
                                 new Claim(ClaimTypes.Role, user.Role.ToString()),
                                 new Claim(ClaimTypes.Role, "Admin")};
            }

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecretKey"]));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: "https://localhost:8888",
                audience: "https://localhost:8888",
                claims: claims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: credentials
            );
            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            var parts = accessToken.Split('.');
            var header = parts[0];
            var payload = parts[1];
            var signature = parts[2];
            var headerAndSignature = $"{header}.{signature}";
            httpResponse.Cookies.Append("payload", payload, new CookieOptions
            {
                HttpOnly = false,
                Expires = DateTime.Now.AddMinutes(10),
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.Strict
            });
            httpResponse.Cookies.Append("headerAndSignature", headerAndSignature, new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.Now.AddMinutes(10),
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.Strict
            });
            httpResponse.Cookies.Append("refreshToken", user.RefreshToken, new CookieOptions
            {
                HttpOnly = true,
                Expires = user.RefreshTokenExpirationDate,
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.Strict
            });
        }

        public async Task DeleteRefreshTokenAsync(User user, HttpResponse httpResponse)
        {
            httpResponse.Cookies.Delete("refreshToken");
            httpResponse.Cookies.Delete("payload");
            httpResponse.Cookies.Delete("headerAndSignature");
            user.RefreshToken = null;
            user.RefreshTokenExpirationDate = null;
            await _context.SaveChangesAsync();
        }
    }
}
