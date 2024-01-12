using System.Text;
using System.Text.Json;

namespace TIN_Project.Shared.Base64Decoder
{
    public class Decoder : IDecoder
    {
        public string DecodeBase64Url(string base64Url)
        {
            var base64 = base64Url.Replace('-', '+').Replace('_', '/');
            var padding = 3 - ((base64.Length + 3) % 4);
            if (padding != 0)
                base64 += new string('=', padding);
            var bytes = Convert.FromBase64String(base64);
            return Encoding.UTF8.GetString(bytes);
        }

        public string? GetUsernameFromToken(string token)
        {
            var jwtPayload = JsonSerializer.Deserialize<Dictionary<string, object>>(token);
            var relevantKeys = jwtPayload.Keys
                .Where(key => key.Contains("name", StringComparison.OrdinalIgnoreCase))
                .ToList();

            return jwtPayload.GetValueOrDefault(relevantKeys.FirstOrDefault(k => k.Contains("name", StringComparison.OrdinalIgnoreCase)))?.ToString();
        }
    }
}
