using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Homework_4_5.Core.Entities;

namespace Homework_4_5.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        IEnumerable<T> Select(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
