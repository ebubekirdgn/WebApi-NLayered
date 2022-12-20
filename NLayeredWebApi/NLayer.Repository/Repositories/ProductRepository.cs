using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using NLayer.Repository.Contexts;

namespace NLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(BaseDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategoryAsync()
        {
           return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}