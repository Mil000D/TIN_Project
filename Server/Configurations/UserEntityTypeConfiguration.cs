using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Configurations
{
	public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(x => x.IdUser);
			builder.Property(x => x.Name).HasMaxLength(20).IsRequired();
			builder.Property(x => x.Surname).HasMaxLength(20).IsRequired();
			builder.Property(x => x.Email).HasMaxLength(30).IsRequired();
			builder.Property(x => x.Username).HasMaxLength(20).IsRequired();
			builder.Property(x => x.Password).HasMaxLength(20).IsRequired();
			builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.Role).IsRequired();
			builder.HasData(
                new User
                {
                    IdUser = 1,
                    Name = "Superuser",
                    Surname = "Superuser",
                    Email = "superuser@superuser.com",
                    Password = "password",
                    Username = "superuser",
                    BirthDate = new DateOnly(2000, 1, 1),
                    Role = Enums.Role.Superuser
                },
                new User
				{
					IdUser = 2,
					Name = "John",
					Surname = "Doe",
					Email = "johndoe@doe.com",
					Password = "password",
					Username = "username",
					BirthDate = new DateOnly(1999, 1, 1),
					Role = Enums.Role.Customer
				},
				new User
				{
					IdUser = 3,
					Name = "Admin",
					Surname = "Admin",
					Email = "admin@admin.com",
					Password = "password",
					Username = "admin",
					BirthDate = new DateOnly(2000, 1, 1),
					Role = Enums.Role.Admin
				}
                );

        }
    }
}
