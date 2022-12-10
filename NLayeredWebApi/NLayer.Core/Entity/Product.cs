﻿namespace NLayer.Core.Entity
{
    public class Product : BaseEntity
    {
        public string Name{ get; set; }
        public int Stock { get; set; }
        public decimal Price{ get; set; }
        public int CategoryId { get; set; }
        public Category Categories{ get; set; }
        public ProductFeature ProductFeatures{ get; set; }

    }
}
