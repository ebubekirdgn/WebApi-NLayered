using Arch.EntityFrameworkCore;
using Arch.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Categories).WithMany(x => x.Products).HasForeignKey(x=> x.CategoryId);
        }

    }
}
