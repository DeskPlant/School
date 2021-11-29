using School.DataBase;
using School.Domain;

namespace School.Repository
{
	public class StudentRepository : IRepository<Student>
	{
		public StudentRepository(SchoolContext schoolContext) : base(schoolContext)
		{
		}
	}
}
