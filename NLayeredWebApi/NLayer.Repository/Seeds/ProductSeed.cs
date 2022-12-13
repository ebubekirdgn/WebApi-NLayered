using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
          new Product { Id = 1, Name = "Kalem", CategoryId = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now },
          new Product { Id = 2, Name = "Audi A8", CategoryId = 2, Price = 100000, Stock = 20, CreatedDate = DateTime.Now },
          new Product { Id = 3, Name = "Monster Laptop", CategoryId = 3, Price = 20000, Stock = 20, CreatedDate = DateTime.Now });
        }
    }
}