﻿using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expresssion);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expresssion);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entitites);
        Task UpdateAsync(T entity);
        Task RemoveAsync(int id);
        Task RemoveRangeAsync(IEnumerable<T> entitites);
    }
}
