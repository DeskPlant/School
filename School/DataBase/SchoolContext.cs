using School.Domain;
using System.Data.Entity;

namespace School.DataBase
{
	public class SchoolContext : DbContext
	{
		public SchoolContext(string nameOrConnectionString) : base(nameOrConnectionString)
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Teacher>()
				.HasMany(teacher => teacher.Students)
				.WithMany(student => student.Teachers);

			modelBuilder.Entity<Student>()
				.HasMany(student => student.Grades)
				.WithOptional()
				.WillCascadeOnDelete(true);
		}

		public DbSet<Grade> Grades { get; set; }

		public DbSet<Student> Students { get; set; }

		public DbSet<Teacher> Teachers { get; set; }
	}
}
