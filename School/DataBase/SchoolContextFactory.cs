using School.Domain;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace School.DataBase
{
	public class SchoolContextFactory : IDbContextFactory<SchoolContext>
	{
		public SchoolContext Create()
		{
			// return new SchoolContext(@"Data Source=BASE\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");
			return new SchoolContext(@"Data Source=PTR\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");
		}
	}
}
