using System.Linq.Expressions;

namespace DataAccess.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Take all results by <typeparamref name="T"/> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns>IEnumerable<<typeparamref name="T"/>></returns>
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null,
            Expression<Func<T, object>>? orderBy = null,
            params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Take on <typeparamref name="T"/> class object by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns><typeparamref name="T"/></returns>
        T GetById(int id);

        /// <summary>
        /// Take first result by <typeparamref name="T"/> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns><typeparamref name="T"/></returns>
        T GetFirstOrDefault(Expression<Func<T, bool>>? filter,
            params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Add in <typeparamref name="T"/> class
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Delete in <typeparamref name="T"/> class
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);

        /// <summary>
        /// Return bool if exists or not exists
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        bool Exist(Expression<Func<T, bool>> filter);

        /// <summary>
        /// Return int count of find in <typeparamref name="T"/> class
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        int Count(Expression<Func<T, bool>>? filter = null);
    }
}
