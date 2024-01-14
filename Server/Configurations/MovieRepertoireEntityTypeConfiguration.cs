using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Configurations
{
	public class MovieRepertoireEntityTypeConfiguration : IEntityTypeConfiguration<MovieRepertoire>
	{
		public void Configure(EntityTypeBuilder<MovieRepertoire> builder)
		{
			builder.HasKey(x => x.IdMovieRepertoire);
			builder.Property(x => x.ShowTime).IsRequired();
            builder.HasOne(x => x.Movie).WithMany(x => x.MovieRepertoires).HasForeignKey(x => x.IdMovie);
            builder.HasOne(x => x.Repertoire).WithMany(x => x.MovieRepertoires).HasForeignKey(x => x.IdRepertoire);
            builder.HasData(new MovieRepertoire
            {
                IdMovieRepertoire = 1,
                IdMovie = 1,
                IdRepertoire = 1,
                ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1))
            },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 2,
                    IdMovie = 2,
                    IdRepertoire = 1,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 3,
                    IdMovie = 3,
                    IdRepertoire = 1,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 4,
                    IdMovie = 4,
                    IdRepertoire = 1,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 5,
                    IdMovie = 5,
                    IdRepertoire = 2,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 6,
                    IdMovie = 6,
                    IdRepertoire = 2,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 7,
                    IdMovie = 7,
                    IdRepertoire = 2,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 8,
                    IdMovie = 1,
                    IdRepertoire = 2,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 9,
                    IdMovie = 2,
                    IdRepertoire = 3,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 10,
                    IdMovie = 3,
                    IdRepertoire = 3,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 11,
                    IdMovie = 4,
                    IdRepertoire = 3,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 12,
                    IdMovie = 5,
                    IdRepertoire = 3,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 13,
                    IdMovie = 6,
                    IdRepertoire = 4,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 14,
                    IdMovie = 7,
                    IdRepertoire = 4,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 15,
                    IdMovie = 1,
                    IdRepertoire = 4,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 16,
                    IdMovie = 2,
                    IdRepertoire = 4,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 17,
                    IdMovie = 3,
                    IdRepertoire = 5,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 18,
                    IdMovie = 4,
                    IdRepertoire = 5,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 19,
                    IdMovie = 5,
                    IdRepertoire = 5,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 20,
                    IdMovie = 6,
                    IdRepertoire = 5,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 21,
                    IdMovie = 7,
                    IdRepertoire = 6,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 22,
                    IdMovie = 1,
                    IdRepertoire = 6,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 23,
                    IdMovie = 2,
                    IdRepertoire = 6,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 24,
                    IdMovie = 3,
                    IdRepertoire = 6,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 25,
                    IdMovie = 4,
                    IdRepertoire = 7,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 26,
                    IdMovie = 5,
                    IdRepertoire = 7,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 27,
                    IdMovie = 6,
                    IdRepertoire = 7,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 28,
                    IdMovie = 7,
                    IdRepertoire = 7,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 29,
                    IdMovie = 1,
                    IdRepertoire = 8,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 30,
                    IdMovie = 2,
                    IdRepertoire = 8,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 31,
                    IdMovie = 3,
                    IdRepertoire = 8,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 32,
                    IdMovie = 4,
                    IdRepertoire = 8,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 33,
                    IdMovie = 5,
                    IdRepertoire = 9,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 34,
                    IdMovie = 6,
                    IdRepertoire = 9,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 35,
                    IdMovie = 7,
                    IdRepertoire = 9,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 36,
                    IdMovie = 1,
                    IdRepertoire = 9,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 37,
                    IdMovie = 2,
                    IdRepertoire = 10,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 38,
                    IdMovie = 3,
                    IdRepertoire = 10,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 39,
                    IdMovie = 4,
                    IdRepertoire = 10,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 40,
                    IdMovie = 5,
                    IdRepertoire = 10,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 41,
                    IdMovie = 6,
                    IdRepertoire = 11,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 42,
                    IdMovie = 7,
                    IdRepertoire = 11,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 43,
                    IdMovie = 8,
                    IdRepertoire = 11,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 44,
                    IdMovie = 9,
                    IdRepertoire = 11,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 45,
                    IdMovie = 10,
                    IdRepertoire = 12,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 46,
                    IdMovie = 11,
                    IdRepertoire = 12,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 47,
                    IdMovie = 12,
                    IdRepertoire = 12,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 48,
                    IdMovie = 13,
                    IdRepertoire = 12,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 49,
                    IdMovie = 14,
                    IdRepertoire = 13,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 50,
                    IdMovie = 15,
                    IdRepertoire = 13,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 51,
                    IdMovie = 16,
                    IdRepertoire = 13,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 52,
                    IdMovie = 17,
                    IdRepertoire = 13,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 53,
                    IdMovie = 18,
                    IdRepertoire = 14,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 54,
                    IdMovie = 19,
                    IdRepertoire = 14,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 55,
                    IdMovie = 20,
                    IdRepertoire = 14,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 56,
                    IdMovie = 1,
                    IdRepertoire = 14,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 57,
                    IdMovie = 2,
                    IdRepertoire = 15,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 58,
                    IdMovie = 3,
                    IdRepertoire = 15,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 59,
                    IdMovie = 4,
                    IdRepertoire = 15,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 60,
                    IdMovie = 5,
                    IdRepertoire = 15,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 61,
                    IdMovie = 6,
                    IdRepertoire = 16,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 62,
                    IdMovie = 7,
                    IdRepertoire = 16,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 63,
                    IdMovie = 8,
                    IdRepertoire = 16,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 64,
                    IdMovie = 9,
                    IdRepertoire = 16,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 65,
                    IdMovie = 10,
                    IdRepertoire = 17,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 66,
                    IdMovie = 11,
                    IdRepertoire = 17,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 67,
                    IdMovie = 12,
                    IdRepertoire = 17,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 68,
                    IdMovie = 13,
                    IdRepertoire = 17,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 69,
                    IdMovie = 14,
                    IdRepertoire = 18,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 70,
                    IdMovie = 15,
                    IdRepertoire = 18,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 71,
                    IdMovie = 16,
                    IdRepertoire = 19,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 72,
                    IdMovie = 17,
                    IdRepertoire = 19,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 73,
                    IdMovie = 18,
                    IdRepertoire = 20,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 74,
                    IdMovie = 19,
                    IdRepertoire = 20,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 75,
                    IdMovie = 20,
                    IdRepertoire = 21,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 76,
                    IdMovie = 1,
                    IdRepertoire = 21,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 77,
                    IdMovie = 2,
                    IdRepertoire = 22,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 78,
                    IdMovie = 3,
                    IdRepertoire = 22,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 79,
                    IdMovie = 4,
                    IdRepertoire = 23,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 80,
                    IdMovie = 5,
                    IdRepertoire = 23,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 81,
                    IdMovie = 6,
                    IdRepertoire = 24,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 82,
                    IdMovie = 7,
                    IdRepertoire = 24,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 83,
                    IdMovie = 8,
                    IdRepertoire = 25,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 84,
                    IdMovie = 9,
                    IdRepertoire = 25,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 85,
                    IdMovie = 10,
                    IdRepertoire = 26,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 86,
                    IdMovie = 11,
                    IdRepertoire = 26,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 87,
                    IdMovie = 12,
                    IdRepertoire = 27,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 88,
                    IdMovie = 13,
                    IdRepertoire = 27,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 89,
                    IdMovie = 14,
                    IdRepertoire = 28,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 90,
                    IdMovie = 15,
                    IdRepertoire = 28,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 91,
                    IdMovie = 16,
                    IdRepertoire = 29,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 92,
                    IdMovie = 17,
                    IdRepertoire = 29,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(3)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 93,
                    IdMovie = 18,
                    IdRepertoire = 30,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(4)),
                },
                new MovieRepertoire
                {
                    IdMovieRepertoire = 94,
                    IdMovie = 19,
                    IdRepertoire = 30,
                    ShowTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)),
                }
            );
        }
	}
}
