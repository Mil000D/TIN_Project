using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Configurations
{
	public class CinemaEntityTypeConfiguration : IEntityTypeConfiguration<Cinema>
	{
		public void Configure(EntityTypeBuilder<Cinema> builder)
		{
			builder.HasKey(x => x.IdCinema);
			builder.Property(x => x.Name).HasMaxLength(30).IsRequired();
			builder.Property(x => x.Address).HasMaxLength(40).IsRequired();
			builder.HasData(new Cinema
							{
								IdCinema = 1,
								Name = "Multikino",
								Address = "Złota 59, 00-120 Warszawa"
							},
							new Cinema
							{
								IdCinema = 2,
								Name = "Cinema City",
								Address = "Wołoska 12, 02-675 Warszawa"
							},
							new Cinema
							{
								IdCinema = 3,
								Name = "Kino Muranów",
								Address = "Gen. W. Andersa 5, 00-147 Warszawa",
							},
							new Cinema
							{
								IdCinema = 4,
								Name = "Kino Luna",
								Address = "Marszałkowska 28, 00-576 Warszawa"
							},
							new Cinema
							{
								IdCinema = 5,
								Name = "Kino Atlantic",
								Address = "Chmielna 33, 00-021 Warszawa"
							},
							new Cinema
							{
								IdCinema = 6,
								Name = "Kino Iluzjon",
								Address = "Ludwika Narbutta 50A, 02-541 Warszawa"
							}
							);
		}
	}
}
