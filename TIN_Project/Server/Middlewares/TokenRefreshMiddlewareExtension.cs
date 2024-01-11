namespace TIN_Project.Server.Middlewares
{
    public static class TokenRefreshMiddlewareExtension
    {
        public static IApplicationBuilder UseTokenRefresh(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TokenRefreshMiddleware>();
        }
    }
}
