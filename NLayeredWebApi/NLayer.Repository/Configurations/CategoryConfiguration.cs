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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id );
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.ToTable("Categories");
        }
    }
}
