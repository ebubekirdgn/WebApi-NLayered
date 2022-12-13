using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entities;
using System.Reflection;

namespace NLayer.Repository.Contexts
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<ProductFeature>()
                .HasData(new ProductFeature()
                {
                    Id = 1,
                    Color = "Kırmızı",
                    Height= 200,
                    Width= 200,
                    ProductId= 1,
                });

            base.OnModelCreating(modelBuilder);
        }
    }

}