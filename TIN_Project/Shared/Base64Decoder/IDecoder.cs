namespace TIN_Project.Shared.Base64Decoder
{
    public interface IDecoder
    {
        public string DecodeBase64Url(string base64Url);
        public string? GetUsernameFromToken(string token);
    }
}
