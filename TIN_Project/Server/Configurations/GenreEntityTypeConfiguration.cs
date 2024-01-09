using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Configurations
{
	public class GenreEntityTypeConfiguration : IEntityTypeConfiguration<Genre>
	{
		public void Configure(EntityTypeBuilder<Genre> builder)
		{
			builder.HasKey(x => x.IdGenre);
			builder.Property(x => x.EnglishName).HasMaxLength(20).IsRequired();
			builder.HasData(new Genre { IdGenre = 1, EnglishName = "Action", PolishName = "Akcja" },
							new Genre { IdGenre = 2, EnglishName = "Adventure", PolishName = "Przygodowy" },
							new Genre { IdGenre = 3, EnglishName = "Comedy", PolishName = "Komedia" },
							new Genre { IdGenre = 4, EnglishName = "Crime", PolishName = "Kryminalny" },
							new Genre { IdGenre = 5, EnglishName = "Drama", PolishName = "Dramat" },
							new Genre { IdGenre = 6, EnglishName = "Fantasy", PolishName = "Fantasy" },
							new Genre { IdGenre = 7, EnglishName = "Historical", PolishName = "Historyczny" },
							new Genre { IdGenre = 8, EnglishName = "Horror", PolishName = "Horror" },
							new Genre { IdGenre = 9, EnglishName = "Mystery", PolishName = "Tajemnica" },
							new Genre { IdGenre = 10, EnglishName = "Romance", PolishName = "Romans" },
							new Genre { IdGenre = 11, EnglishName = "Science Fiction", PolishName = "Science Fiction" },
							new Genre { IdGenre = 12, EnglishName = "Thriller", PolishName = "Thriller" },
							new Genre { IdGenre = 13, EnglishName = "Western", PolishName = "Western" }
							);
		}
	}
}
