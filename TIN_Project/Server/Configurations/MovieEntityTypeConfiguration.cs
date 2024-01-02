using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Configurations
{
	public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			builder.HasKey(x => x.IdMovie);
			builder.Property(x => x.Title).HasMaxLength(40).IsRequired();
			builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
			builder.Property(x => x.TrailerUrl).HasMaxLength(100).IsRequired();
			builder.Property(x => x.PosterUrl).HasMaxLength(100).IsRequired();
            builder
             .HasMany(p => p.Genres)
                .WithMany(t => t.Movies)
                .UsingEntity<Dictionary<string, object>>(
                    "GenreMovie",
                    r => r.HasOne<Genre>().WithMany().HasForeignKey("GenresIdGenre"),
                    l => l.HasOne<Movie>().WithMany().HasForeignKey("MoviesIdMovie"),
                    je =>
                    {
                        je.HasKey("MoviesIdMovie", "GenresIdGenre");
						je.HasData(
							new { MoviesIdMovie = 1, GenresIdGenre = 1 },
							new { MoviesIdMovie = 1, GenresIdGenre = 11 },
							new { MoviesIdMovie = 2, GenresIdGenre = 11 },
							new { MoviesIdMovie = 2, GenresIdGenre = 12 },
							new { MoviesIdMovie = 3, GenresIdGenre = 1 },
							new { MoviesIdMovie = 3, GenresIdGenre = 12 },
							new { MoviesIdMovie = 4, GenresIdGenre = 6 },
							new { MoviesIdMovie = 5, GenresIdGenre = 11 },
							new { MoviesIdMovie = 6, GenresIdGenre = 4 },
							new { MoviesIdMovie = 6, GenresIdGenre = 12 },
							new { MoviesIdMovie = 7, GenresIdGenre = 13 });
                    });
            builder.HasData(new Movie
							{
								IdMovie = 1,
								Title = "The Avengers",
								Description = "A team of superheroes save the world from a powerful threat.",
								TrailerUrl = "https://www.youtube.com/watch?v=eOrNdBpGMv8",
								PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
							},
							new Movie
							{
								IdMovie = 2,
								Title = "Inception",
								Description = "A thief enters people's dreams to steal information.",
								TrailerUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0",
								PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/oYuLEt3zVCKq57qu2F8dT7NIa6f.jpg",
							},
							new Movie
							{
								IdMovie = 3,
								Title = "The Dark Knight",
								Description = "A vigilante fights crime in Gotham City.",
								TrailerUrl = "https://www.youtube.com/watch?v=EXeTwQWrcwY",
								PosterUrl = "https://www.themoviedb.org/t/p/original/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
							},
							new Movie
							{
								IdMovie = 4,
								Title = "The Lord of the Rings: The Fellowship of the Ring",
								Description = "A hobbit embarks on a journey to destroy a powerful ring.",
								TrailerUrl = "https://www.youtube.com/watch?v=V75dMMIW2B4",
								PosterUrl = "https://www.themoviedb.org/t/p/original/6oom5QYQ2yQTMJIbnvbkBL9cHo6.jpg",
							},
							new Movie
							{
								IdMovie = 5,
								Title = "The Matrix",
								Description = "A hacker discovers that the world is a simulation.",
								TrailerUrl = "https://www.youtube.com/watch?v=m8e-FF8MsqU",
								PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qK76PKQLd6zlMn0u83Ej9YQOqPL.jpg",
							},
							new Movie
							{
								IdMovie = 6,
								Title = "Pulp Fiction",
								Description = "Various interconnected stories of criminals, lowlifes, and a mysterious briefcase.",
								TrailerUrl = "https://www.youtube.com/watch?v=s7EdQ4FqbhY",
								PosterUrl = "https://www.themoviedb.org/t/p/w1280/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg",
							},
							new Movie
							{
								IdMovie = 7,
								Title = "Django Unchained",
								Description = "A freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
								TrailerUrl = "https://www.youtube.com/watch?v=_iH0UBYDI4g",
								PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6UjfRbaSdpNeaJvLIPTdhCO6yzJ.jpg",
							}
							);
			
		}
	}
}
