using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _service;

        public CategoriesController(IMapper mapper, IService<Category> service, ICategoryService categoryService)
        {
            _mapper = mapper;
            _service = categoryService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            return CreateActionResult(await _service.GetSingleCategoryByIdWithProductsAsync(categoryId));

        }
    }
}