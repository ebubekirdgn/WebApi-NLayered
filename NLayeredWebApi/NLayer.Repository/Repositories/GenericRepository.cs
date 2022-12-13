using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using NLayer.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T:  class
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
            await _context.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entitites)
        {
            await _context.AddRangeAsync(entitites);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expresssion)
        {
            return await _dbSet.AnyAsync(expresssion);
        }

        public async IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
             
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entitites)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expresssion)
        {
            throw new NotImplementedException();
        }
    }
}
