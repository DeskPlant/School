using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Domain
{
	public class Teacher : IEntity
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		public ICollection<Student> Students { get; set; }

		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}
	}
}
