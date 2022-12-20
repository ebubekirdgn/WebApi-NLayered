namespace NLayer.Core.Dtos
{
    public class CategoryWithProductDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}