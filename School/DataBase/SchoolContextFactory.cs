using System.Data.Entity.Infrastructure;
using System.IO;
using System.Text.RegularExpressions;

namespace School.DataBase
{
	public class SchoolContextFactory : IDbContextFactory<SchoolContext>
	{
		public SchoolContext Create()
		{
			Regex regex = new(@"<add key=\""connection-string"" value=""(?<value>.*)"" \/>");

			string xmlFile = File.ReadAllText("App.config");

			string connectionString = regex.Match(xmlFile).Groups["value"].Value;

			return new SchoolContext(connectionString);
		}
	}
}
