using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using NLayer.Repository.Contexts;
using System.Linq.Expressions;

namespace NLayer.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly BaseDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(BaseDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entitites)
        {
            await _dbSet.AddRangeAsync(entitites);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expresssion)
        {
            return await _dbSet.AnyAsync(expresssion);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entitites)
        {
            _dbSet.RemoveRange(entitites);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expresssion)
        {
            return _dbSet.Where(expresssion);
        }
    }
}