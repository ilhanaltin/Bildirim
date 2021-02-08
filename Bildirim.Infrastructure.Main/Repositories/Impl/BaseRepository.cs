using Bildirim.App.Migrations;
using Bildirim.Infrastructure.Main.Repositories.Interfaces;
using Bildirim.Domain.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Bildirim.Infrastructure.Main.Repositories.Impl
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        internal DbSet<T> DBSET;

        private readonly BildirimContext _context;

        protected BaseRepository(BildirimContext context)
        {
            _context = context;
            DBSET = context._Set<T>();
        }

        public IQueryable<T> GetAll(Expression<Func<T, object>>[] includeProperties = null)
        {
            var result = DBSET.AsQueryable();

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    result = result.Include(includeProperty).AsQueryable();
                }
            }

            return result;
        }

        public T GetIncluding(Expression<Func<T, bool>> whereExpression,
            params Expression<Func<T, object>>[] includeProperties)
        {
            var queryable = DBSET.Where(whereExpression);

            foreach (var includeProperty in includeProperties)
            {
                queryable = queryable.Include(includeProperty);
            }

            return queryable.FirstOrDefault();
        }

        public List<T> GetList(Expression<Func<T, bool>> whereExpression)
        {
            var result = DBSET.Where(whereExpression).ToList();

            return result;
        }

        public virtual IQueryable<T> GetQ(Expression<Func<T, bool>> whereExpression)
        {
            return GetAll().Where(whereExpression).AsQueryable();
        }

        public virtual T Get(Expression<Func<T, bool>> whereExpression)
        {
            var result = DBSET.FirstOrDefault(whereExpression);

            return result;
        }

        public virtual void Add(T item)
        {
            item.CreatedDateTime = DateTime.Now;

            DBSET.Attach(item);
            _context.Entry(item).State = EntityState.Added;

            _context.SaveChanges();
        }

        public void Add(T[] items)
        {
            foreach (var item in items)
            {
                item.CreatedDateTime = DateTime.Now;

                DBSET.Attach(item);
                _context.Entry(item).State = EntityState.Added;
            }

            _context.SaveChanges();
        }

        public virtual void Update(T item)
        {
            item.UpdatedDateTime = DateTime.Now;

            DBSET.Attach(item);
            _context.Entry(item).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public void Update(T[] items)
        {
            foreach (var item in items)
            {
                item.UpdatedDateTime = DateTime.Now;

                DBSET.Attach(item);
                _context.Entry(item).State = EntityState.Modified;
            }

            _context.SaveChanges();
        }

        public void Remove(T item)
        {
            if (_context.Entry(item).State == EntityState.Detached)
            {
                DBSET.Attach(item);
            }
            dynamic o = DBSET.Remove(item);
            _context.SaveChanges();
        }

        public void Remove(T[] items)
        {
            foreach (var item in items)
            {
                if (_context.Entry(item).State == EntityState.Detached)
                {
                    DBSET.Attach(item);
                }

                dynamic o = DBSET.Remove(item);
            }

            _context.SaveChanges();
        }

        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> queryable = GetAll();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {
                queryable = queryable.Include<T, object>(includeProperty);
            }

            return queryable;
        }

        public bool Any(Expression<Func<T, bool>> whereExpression)
        {
            return Get(whereExpression) != null;
        }        
    }
}
