using FluentValidation;
namespace KitchenStoryWebAPI.DTO.ProductSubCategory.Validation
{
    public class ProductSubCategoryInsertRequestValidator  : AbstractValidator<ProductSubCategoryInsertRequest>
    {
        public ProductSubCategoryInsertRequestValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Product Sub Category name cant be empty ");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Product Sub Category Description cant be empty ");
            RuleFor(x => x.ProductCategoryId).GreaterThan(0).WithMessage("ProductId must be then zero in Sub Category  ");
            RuleFor(x=>x.tags).NotEmpty();

        }
    }
}
