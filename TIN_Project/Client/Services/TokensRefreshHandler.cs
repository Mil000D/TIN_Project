namespace TIN_Project.Client.Services
{
    public class TokensRefreshHandler : ITokensRefreshHandler
    {
        private readonly HttpClient _httpClient;

        public TokensRefreshHandler(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task RefreshTokensAsync()
        {
            var response = await _httpClient.GetAsync("api/authentication/refresh");
            if (!response.IsSuccessStatusCode)
            {
                await RefreshTokensUsingRefreshTokenAsync();
            }
        }

        private async Task RefreshTokensUsingRefreshTokenAsync()
        {
            var response = await _httpClient.GetAsync("api/authentication");
            if (!response.IsSuccessStatusCode)
            {
                return;
            }
        }
    }
}
