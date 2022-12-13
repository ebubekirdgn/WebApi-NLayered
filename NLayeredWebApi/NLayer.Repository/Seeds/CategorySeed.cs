﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category{Id=1 , Name ="Kırtasiye"},
                new Category{Id=2 , Name ="Otomotiv"},
                new Category{Id=3 , Name ="Teknoloji"});
        }
    }
}
