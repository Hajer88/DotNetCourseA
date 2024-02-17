using System;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.DMWMA.MVC.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options)
			:base(options)
		{
		}

		public DbSet<Movie> movies { get; set; }


	}
}

