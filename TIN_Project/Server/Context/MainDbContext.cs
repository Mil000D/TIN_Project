using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Context
{
	public class MainDbContext : DbContext
	{
		public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
		{
		}
		protected MainDbContext()
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Cinema> Cinemas { get; set; }
		public DbSet<MovieRepertoire> MovieRepertoires { get; set; }
		public DbSet<Repertoire> Repertoires { get; set; }
		public DbSet<Order> Orders { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);
		}
	}
}
