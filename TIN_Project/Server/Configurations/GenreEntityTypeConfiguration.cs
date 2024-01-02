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
			builder.Property(x => x.Name).HasMaxLength(20).IsRequired();
			builder.HasData(new Genre { IdGenre = 1, Name = "Action" },
							new Genre { IdGenre = 2, Name = "Adventure" },
							new Genre { IdGenre = 3, Name = "Comedy" },
							new Genre { IdGenre = 4, Name = "Crime" },
							new Genre { IdGenre = 5, Name = "Drama" },
							new Genre { IdGenre = 6, Name = "Fantasy" },
							new Genre { IdGenre = 7, Name = "Historical" },
							new Genre { IdGenre = 8, Name = "Horror" },
							new Genre { IdGenre = 9, Name = "Mystery" },
							new Genre { IdGenre = 10, Name = "Romance" },
							new Genre { IdGenre = 11, Name = "Science Fiction" },
							new Genre { IdGenre = 12, Name = "Thriller" },
							new Genre { IdGenre = 13, Name = "Western" }
							);
		}
	}
}
