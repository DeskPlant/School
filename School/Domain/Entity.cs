using System;
using System.ComponentModel.DataAnnotations;

namespace School.Domain
{
	public interface IEntity
	{
		[Key]
		public Guid Id { get; set; }
	}
}
