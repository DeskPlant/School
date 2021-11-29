using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Domain
{
	public class Student : IEntity
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		public ICollection<Grade> Grades { get; set; }

		public ICollection<Teacher> Teachers { get; set; }

		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}
	}
}
