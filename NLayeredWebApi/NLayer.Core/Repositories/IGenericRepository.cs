using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        IQueryable<T> Where(Expression<Func<T, bool>> expresssion);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expresssion);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entitites);

        void Update(T entity);

        void Remove(int id);

        void RemoveRange(IEnumerable<T> entitites);
    }
}