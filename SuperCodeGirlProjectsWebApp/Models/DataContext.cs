using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCodeGirlProjectsWebApp.Models
{
	public class DataContext : DbContext
	{
		public DataContext (DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Project> Projects { get; set; }
		public DbSet<Technology> Technologies { get; set; }
		public DbSet<BlogPost> BlogPosts { get; set; }
		public DbSet<MainCategory> MainCategories { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }


	}
}
