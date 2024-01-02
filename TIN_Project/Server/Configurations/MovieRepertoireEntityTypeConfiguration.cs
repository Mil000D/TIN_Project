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
                }
            );
        }
	}
}
