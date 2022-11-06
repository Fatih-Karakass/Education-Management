
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);

        Task<T> GetAsync(Expression<Func<T, bool>>? filter);

        void AddAsync(T entity);

        void Remove(T entity);

        void Update(T entity);

    }
}
