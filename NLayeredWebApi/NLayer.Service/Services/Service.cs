using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnifOfWorks;
using System.Linq.Expressions;

namespace NLayer.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnifOfWorks _unifOfWorks;

        public Service(IGenericRepository<T> repository, IUnifOfWorks unifOfWorks)
        {
            _repository = repository;
            _unifOfWorks = unifOfWorks;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unifOfWorks.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entitites)
        {
            await _repository.AddRangeAsync(entitites);
            await _unifOfWorks.CommitAsync();
            return entitites;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expresssion)
        {
            return await _repository.AnyAsync(expresssion);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _unifOfWorks.CommitAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entitites)
        {
            _repository.RemoveRange(entitites);
            await _unifOfWorks.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _unifOfWorks.CommitAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expresssion)
        {
            return _repository.Where(expresssion);
        }
    }
}