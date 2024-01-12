using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TIN_Project.Server.Context;
using TIN_Project.Server.TokenManagers;
using TIN_Project.Server.Mappers.UserMappers;
using TIN_Project.Server.Services.MoviesServices;
using TIN_Project.Server.Mappers.MovieMappers;
using TIN_Project.Server.Services.UsersServices;
using TIN_Project.Server.Services.GenresServices;
using TIN_Project.Server.Mappers.GenreMappers;
using TIN_Project.Server.Services.CinemasServices;
using TIN_Project.Server.Mappers.CinemaMappers;
using TIN_Project.Server.Services.RepertoiresServices;
using TIN_Project.Server.Mappers.RepertoireMappers;
using TIN_Project.Server.Mappers.MoviesRepertoireMappers;
using TIN_Project.Server.Services.MoviesRepertoiresServices;
using TIN_Project.Server.Mappers.OrderMappers;
using TIN_Project.Server.Services.OrdersServices;
using TIN_Project.Shared.Base64Decoder;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRazorPages().AddDataAnnotationsLocalization();
builder.Services.AddScoped<ITokenManager, TokenManager>();
builder.Services.AddScoped<IUsersDbService, UsersDbService>();
builder.Services.AddScoped<IUserMapper, UserMapper>();
builder.Services.AddScoped<IMoviesDbService, MoviesDbService>();
builder.Services.AddScoped<IMovieMapper, MovieMapper>();
builder.Services.AddScoped<IGenresDbService, GenresDbService>();
builder.Services.AddScoped<IGenreMapper, GenreMapper>();
builder.Services.AddScoped<ICinemasDbService, CinemasDbService>();
builder.Services.AddScoped<ICinemaMapper, CinemaMapper>();
builder.Services.AddScoped<IRepertoiresDbService, RepertoiresDbService>();
builder.Services.AddScoped<IRepertoireMapper, RepertoireMapper>();
builder.Services.AddScoped<IMoviesRepertoiresDbService, MoviesRepertoiresDbService>();
builder.Services.AddScoped<IMoviesRepertoireMapper,  MoviesRepertoireMapper>();
builder.Services.AddScoped<IOrdersDbService, OrdersDbService>();
builder.Services.AddScoped<IOrderMapper, OrderMapper>();
builder.Services.AddSingleton<IDecoder, TIN_Project.Shared.Base64Decoder.Decoder>();
builder.Services.AddDbContext<MainDbContext>(options =>
{
    options.UseSqlite($"Data Source={Path.Combine(Directory.GetCurrentDirectory(), @"Database\database.db")}");
});
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.Cookie.Name = "payload";
    options.Cookie.Name = "headerAndSignature";
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidIssuer = "https://localhost:8888",
        ValidAudience = "https://localhost:8888",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["SecretKey"]))
    };
    options.Events = new JwtBearerEvents
    {
        OnMessageReceived = context =>
        {
            var headerAndSignature = context.Request.Cookies["headerAndSignature"];
            var payload = context.Request.Cookies["payload"];
            var parts = headerAndSignature?.Split('.');
            var header = parts?[0];
            var signature = parts?[1];
            var accessToken = $"{header}.{payload}.{signature}";
            context.Token = accessToken;
            return Task.CompletedTask;
        }
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
