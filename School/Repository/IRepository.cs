using School.DataBase;
using School.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School.Repository
{
	public abstract class IRepository<T> where T : class, IEntity, new()
	{
		private readonly SchoolContext schoolContext;

		protected IRepository(SchoolContext schoolContext)
		{
			this.schoolContext = schoolContext;
		}

		public void Add(T item)
		{
			schoolContext.Set<T>().Add(item);

			schoolContext.SaveChangesAsync();
		}

		public void Delete(Guid id)
		{
			Delete(new T { Id = id });
		}

		public void Delete(T t)
		{
			schoolContext.Set<T>().Attach(t);

			schoolContext.Set<T>().Remove(t);

			schoolContext.SaveChangesAsync();
		}

		public IEnumerable<T> GetAll()
		{
			return schoolContext.Set<T>().AsNoTracking();
		}
	}
}
