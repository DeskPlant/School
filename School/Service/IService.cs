using School.Domain;
using School.Repository;
using System;
using System.Collections.Generic;

namespace School.Service
{
    public abstract class IService<T> where T : class, IEntity, new()
    {
        public IRepository<T> Repository { get; set; }

        public IService(IRepository<T> repository)
        {
            Repository = repository;
        }

        public void Add(T item)
        {
            Repository.Add(item);
        }

        public void Delete(T item)
        {
            Repository.Delete(item);
        }

        public void Delete(Guid id)
        {
            Delete(new T { Id = id });
        }

        public IEnumerable<T> GetAll()
        {
           return Repository.GetAll();
        }

        public T Get(Guid id)
        {
            return Repository.Get(id);
        }
    }
}
