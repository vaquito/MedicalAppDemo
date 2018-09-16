using MedicalDemo.Entities;
using MedicalDemo.Entities.DataBase;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MedicalDemo.Business.Interfaces
{
    public interface IRepository<T> where T : EntidadBase
    {
        T GetById(int id, string includeProperties = "");
        IEnumerable<T> List(string includeProperties = "");
        IEnumerable<T> List(Expression<Func<T, bool>> predicate, string includeProperties = "");
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }

    
}
