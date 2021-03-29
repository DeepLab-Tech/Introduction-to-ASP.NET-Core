using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CourseProjectRecap.Services.IRepository
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByFilter(Func<T, bool> predicate);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Count(Func<T, bool> predicate);
    }
}