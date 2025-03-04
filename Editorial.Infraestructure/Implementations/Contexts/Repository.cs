﻿using Editorial.Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Infraestructure.Implementations.Contexts
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(DbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }


        readonly DbContext _context;
        readonly DbSet<T> _set;


        public T Get(object id)
        {
            return _set.Find(id);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _set.FirstOrDefault(predicate);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = _set;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }

            return query;

        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _set.Add(entity);

        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _set.Update(entity);
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _set.Remove(entity);
        }



        public void Delete(object id)
        {
            Delete(Get(id));
        }

    }
}
