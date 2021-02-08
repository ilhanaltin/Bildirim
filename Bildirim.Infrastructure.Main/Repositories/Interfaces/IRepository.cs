using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Bildirim.Infrastructure.Main.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll(Expression<Func<T, object>>[] includeProperties = null);

        IQueryable<T> GetQ(Expression<Func<T, bool>> whereExpression);

        List<T> GetList(Expression<Func<T, bool>> whereExpression);

        T Get(Expression<Func<T, bool>> whereExpression);

        void Add(T item);

        void Add(T[] items);

        void Update(T item);

        void Update(T[] items);

        void Remove(T item);

        void Remove(T[] items);

        T GetIncluding(Expression<Func<T, bool>> whereExpression,
            params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        bool Any(Expression<Func<T, bool>> whereExpression);        
    }
}
