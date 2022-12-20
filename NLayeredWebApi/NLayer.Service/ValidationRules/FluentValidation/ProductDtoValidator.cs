using FluentValidation;
using NLayer.Core.Entities;

namespace NLayer.Service.ValidationRules.FluentValidation
{
    public class ProductDtoValidator:AbstractValidator<Product>
    {
        public ProductDtoValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(p => p.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater than 0");
            RuleFor(p => p.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater than 0");
            RuleFor(p => p.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be grater than 0");
        }
    }
}