using School.DataBase;
using School.Domain;

namespace School.Repository
{
	public class TeacherRepository : IRepository<Teacher>
	{
		public TeacherRepository(SchoolContext schoolContext) : base(schoolContext)
		{
		}
	}
}
