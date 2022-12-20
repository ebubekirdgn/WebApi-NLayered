﻿using AutoMapper;
using NLayer.Core.Dtos;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnifOfWorks;

namespace NLayer.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnifOfWorks unifOfWorks, IProductRepository productRepository, IMapper mapper) : base(repository, unifOfWorks)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<ProductWithCategory>>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();
            var productsDto = _mapper.Map<List<ProductWithCategory>>(products);
            return CustomResponseDto<List<ProductWithCategory>>.Success(200, productsDto);
        }
    }
}