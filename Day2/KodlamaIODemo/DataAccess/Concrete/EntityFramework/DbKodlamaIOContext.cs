using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class DbKodlamaIOContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//Connection string yazarız
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DbKodlamaIO;Trusted_Connection=true");
		}

		public DbSet<Course> Courses { get; set; }
		public DbSet<Instructor> Instructors { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
