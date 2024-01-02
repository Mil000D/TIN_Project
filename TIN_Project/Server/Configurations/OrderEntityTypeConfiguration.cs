using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Configurations
{
	public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.HasKey(x => new { x.IdUser, x.IdMovieRepertoire });
			builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.IdUser);
			builder.HasOne(x => x.MovieRepertoire).WithMany(x => x.Orders).HasForeignKey(x => x.IdMovieRepertoire);
			builder.Property(x => x.IsPaid).IsRequired();
		}
	}
}
