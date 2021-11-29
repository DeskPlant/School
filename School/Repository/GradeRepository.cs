using School.DataBase;
using School.Domain;

namespace School.Repository
{
	public class GradeRepository : IRepository<Grade>
	{
		public GradeRepository(SchoolContext schoolContext) : base(schoolContext)
		{
		}
	}
}
