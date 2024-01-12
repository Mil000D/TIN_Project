using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Configurations
{
	public class RepertoireEntityTypeConfiguration : IEntityTypeConfiguration<Repertoire>
	{
		public void Configure(EntityTypeBuilder<Repertoire> builder)
		{
			builder.HasKey(x => x.IdRepertoire);
			builder.Property(x => x.Date).IsRequired();
			builder.HasOne(x => x.Cinema).WithMany(x => x.Repertoires).HasForeignKey(x => x.IdCinema);
			builder.HasData( new Repertoire { IdRepertoire = 1, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), IdCinema = 1 },
                             new Repertoire { IdRepertoire = 2, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), IdCinema = 1 },
                             new Repertoire { IdRepertoire = 3, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), IdCinema = 1 },
                             new Repertoire { IdRepertoire = 4, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), IdCinema = 1 },
                             new Repertoire { IdRepertoire = 5, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), IdCinema = 1 },
                             new Repertoire { IdRepertoire = 6, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), IdCinema = 2 },
                             new Repertoire { IdRepertoire = 7, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), IdCinema = 2 },
							 new Repertoire { IdRepertoire = 8, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), IdCinema = 2 },
                             new Repertoire { IdRepertoire = 9, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), IdCinema = 2 },
                             new Repertoire { IdRepertoire = 10, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), IdCinema = 2 },
                             new Repertoire { IdRepertoire = 11, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), IdCinema = 3 },
                             new Repertoire { IdRepertoire = 12, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), IdCinema = 3 },
                             new Repertoire { IdRepertoire = 13, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), IdCinema = 3 },
                             new Repertoire { IdRepertoire = 14, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), IdCinema = 3 },
                             new Repertoire { IdRepertoire = 15, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), IdCinema = 3 },
                             new Repertoire { IdRepertoire = 16, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), IdCinema = 4 },
                             new Repertoire { IdRepertoire = 17, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), IdCinema = 4 },
                             new Repertoire { IdRepertoire = 18, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), IdCinema = 4 },
                             new Repertoire { IdRepertoire = 19, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), IdCinema = 4 },
                             new Repertoire { IdRepertoire = 20, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), IdCinema = 4 },
                             new Repertoire { IdRepertoire = 21, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), IdCinema = 5 },
                             new Repertoire { IdRepertoire = 22, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), IdCinema = 5 },
                             new Repertoire { IdRepertoire = 23, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), IdCinema = 5 },
                             new Repertoire { IdRepertoire = 24, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), IdCinema = 5 },
                             new Repertoire { IdRepertoire = 25, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), IdCinema = 5 },
                             new Repertoire { IdRepertoire = 26, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), IdCinema = 6 },
                             new Repertoire { IdRepertoire = 27, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), IdCinema = 6 },
                             new Repertoire { IdRepertoire = 28, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), IdCinema = 6 },
                             new Repertoire { IdRepertoire = 29, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), IdCinema = 6 },
                             new Repertoire { IdRepertoire = 30, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), IdCinema = 6 }
                             );
        }
	}
}
