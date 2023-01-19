using DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null,
            Expression<Func<T, object>>? orderBy = null,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = dbSet.AsNoTracking();
            if (filter != null && orderBy == null)
            {
                query = query.Where(filter);
            }
            else if (filter == null && orderBy != null)
            {
                query = query.OrderBy(orderBy);
            }
            else if (filter != null && orderBy != null)
            {
                query = query.Where(filter).OrderBy(orderBy);
            }
            if (includes.Count() > 0)
            {
                query = includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }
            return query.ToList();
        }
        public T GetById(int id)
        {
            return dbSet.Find(id);
        }
        public T GetFirstOrDefault(Expression<Func<T, bool>>? filter,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = dbSet.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includes.Count() > 0)
            {
                query = includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }
            return query.FirstOrDefault();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public bool Exist(Expression<Func<T, bool>> filter)
        {
            if (filter == null)
                return false;
            return dbSet.Any(filter);
        }

        public int Count(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                return query.Count(filter);
            }
            else
            {
                return query.Count();
            }
        }
    }
}
