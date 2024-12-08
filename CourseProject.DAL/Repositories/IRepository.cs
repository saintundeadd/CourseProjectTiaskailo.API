using System;
using System.Collections.Generic;

namespace CourseProject.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}