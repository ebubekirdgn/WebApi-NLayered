using NLayer.Core.Dtos;
using NLayer.Core.Entities;

namespace NLayer.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryByIdWithProductsAsync();
    }
}