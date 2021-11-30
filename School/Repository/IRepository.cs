﻿using School.DataBase;
using School.Domain;
using System.Collections.Generic;

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

        public void Delete(T item)
		{
			schoolContext.Set<T>().Attach(item);

			schoolContext.Set<T>().Remove(item);

			schoolContext.SaveChanges();
		}

		public IEnumerable<T> GetAll()
		{
			return schoolContext.Set<T>().AsNoTracking();
		}
	}
}
