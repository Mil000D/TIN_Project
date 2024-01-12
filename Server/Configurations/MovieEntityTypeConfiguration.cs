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
			builder.Property(x => x.EnglishTitle).HasMaxLength(40).IsRequired();
			builder.Property(x => x.PolishTitle).HasMaxLength(40).IsRequired();
			builder.Property(x => x.EnglishDescription).HasMaxLength(1000).IsRequired();
			builder.Property(x => x.PolishDescription).HasMaxLength(1000).IsRequired();
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
								EnglishTitle = "The Avengers",
								PolishTitle = "Avengers",
								EnglishDescription = "A team of superheroes save the world from a powerful threat.",
								PolishDescription = "Zespół superbohaterów ratuje świat przed potężnym zagrożeniem.",
								TrailerUrl = "https://www.youtube.com/watch?v=eOrNdBpGMv8",
								PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
							},
							new Movie
							{
								IdMovie = 2,
								EnglishTitle = "Inception",
								PolishTitle = "Incepcja",
								EnglishDescription = "A thief enters people's dreams to steal information.",
								PolishDescription = "Złodziej wkracza do snów ludzi, aby ukraść informacje.",
								TrailerUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0",
								PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/oYuLEt3zVCKq57qu2F8dT7NIa6f.jpg",
							},
							new Movie
							{
								IdMovie = 3,
								EnglishTitle = "The Dark Knight",
								PolishTitle = "Mroczny Rycerz",
								EnglishDescription = "A vigilante fights crime in Gotham City.",
								PolishDescription = "Samozwańczy sprawiedliwy walczy ze złem w Gotham City.",
								TrailerUrl = "https://www.youtube.com/watch?v=EXeTwQWrcwY",
								PosterUrl = "https://www.themoviedb.org/t/p/original/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
							},
							new Movie
							{
								IdMovie = 4,
								EnglishTitle = "The Lord of the Rings: The Fellowship of the Ring",
								PolishTitle = "Władca Pierścieni: Drużyna Pierścienia",
								EnglishDescription = "A hobbit embarks on a journey to destroy a powerful ring.",
								PolishDescription = "Hobbit wyrusza w podróż, aby zniszczyć potężny pierścień.",
								TrailerUrl = "https://www.youtube.com/watch?v=V75dMMIW2B4",
								PosterUrl = "https://www.themoviedb.org/t/p/original/6oom5QYQ2yQTMJIbnvbkBL9cHo6.jpg",
							},
							new Movie
							{
								IdMovie = 5,
								EnglishTitle = "The Matrix",
								PolishTitle = "Matrix",
								EnglishDescription = "A hacker discovers that the world is a simulation.",
								PolishDescription = "Haker odkrywa, że świat jest symulacją.",
								TrailerUrl = "https://www.youtube.com/watch?v=m8e-FF8MsqU",
								PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qK76PKQLd6zlMn0u83Ej9YQOqPL.jpg",
							},
							new Movie
							{
								IdMovie = 6,
								EnglishTitle = "Pulp Fiction",
								PolishTitle = "Pulp Fiction",
								EnglishDescription = "Various interconnected stories of criminals, lowlifes, and a mysterious briefcase.",
								PolishDescription = "Różne powiązane ze sobą historie kryminalistów, łotrów i tajemniczej walizki.",
								TrailerUrl = "https://www.youtube.com/watch?v=s7EdQ4FqbhY",
								PosterUrl = "https://www.themoviedb.org/t/p/w1280/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg",
							},
							new Movie
							{
								IdMovie = 7,
								EnglishTitle = "Django Unchained",
								PolishTitle = "Django",
								EnglishDescription = "A freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
								PolishDescription = "Uwolniony niewolnik wyrusza, aby uratować swoją żonę przed brutalnym właścicielem plantacji w Missisipi.",
								TrailerUrl = "https://www.youtube.com/watch?v=_iH0UBYDI4g",
								PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6UjfRbaSdpNeaJvLIPTdhCO6yzJ.jpg",
							}
							);
			
		}
	}
}
