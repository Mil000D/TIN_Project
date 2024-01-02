using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
namespace TIN_Project.Client.Services
{
    public class UserAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime _jsRuntime;

        public UserAuthenticationStateProvider(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var cookieValue = await _jsRuntime.InvokeAsync<string>("getCookie", "payload");

            if (string.IsNullOrEmpty(cookieValue))
            {
                return new AuthenticationState(new ClaimsPrincipal());
            }

            var payload = DecodeBase64Url(cookieValue);
            var jwtPayload = JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            var relevantKeys = jwtPayload.Keys
                .Where(key => key.Contains("name", StringComparison.OrdinalIgnoreCase) || key.Contains("role", StringComparison.OrdinalIgnoreCase))
                .ToList();
            var username = jwtPayload.GetValueOrDefault(relevantKeys.FirstOrDefault(k => k.Contains("name", StringComparison.OrdinalIgnoreCase)))?.ToString();
            var role = jwtPayload.GetValueOrDefault(relevantKeys.FirstOrDefault(k => k.Contains("role", StringComparison.OrdinalIgnoreCase)))?.ToString();
            var claims = new[] { new Claim(ClaimTypes.Name, username),
                                 new Claim(ClaimTypes.Role, role)};
            if(role.Contains("Superuser"))
            {
                claims = new[] { new Claim(ClaimTypes.Name, username),
                                 new Claim(ClaimTypes.Role, "Superuser"),
                                 new Claim(ClaimTypes.Role, "Admin")};
            }
            var identity = new ClaimsIdentity(claims, "CookieAuthentication");
            var principal = new ClaimsPrincipal(identity);
            return new AuthenticationState(principal);
        }

        private string DecodeBase64Url(string base64Url)
        {
            var base64 = base64Url.Replace('-', '+').Replace('_', '/');
            var padding = 3 - ((base64.Length + 3) % 4);
            if (padding != 0)
                base64 += new string('=', padding);
            var bytes = Convert.FromBase64String(base64);
            return Encoding.UTF8.GetString(bytes);
        }

        public void AuthenticateUser()
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}

