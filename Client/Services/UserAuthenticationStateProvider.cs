using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using TIN_Project.Shared.Base64Decoder;
namespace TIN_Project.Client.Services
{
    public class UserAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IDecoder _decoder;

        public UserAuthenticationStateProvider(IJSRuntime jsRuntime, IDecoder decoder)
        {
            _jsRuntime = jsRuntime;
            _decoder = decoder;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var cookieValue = await _jsRuntime.InvokeAsync<string>("getCookie", "payload");

            if (string.IsNullOrEmpty(cookieValue))
            {
                return new AuthenticationState(new ClaimsPrincipal());
            }

            var payload = _decoder.DecodeBase64Url(cookieValue);
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

        public void AuthenticateUser()
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}

