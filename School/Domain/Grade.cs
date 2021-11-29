using System;
using System.ComponentModel.DataAnnotations;

namespace School.Domain
{
	public class Grade : IEntity
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public float Value { get; set; }

		public string Subject { get; set; }

		public override string ToString()
		{
			return $"{Value} in {Subject}";
		}
	}
}
