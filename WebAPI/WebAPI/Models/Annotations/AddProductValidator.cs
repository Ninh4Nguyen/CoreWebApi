using FluentValidation;
using WebAPI.Models.API;

namespace WebAPI.Models.Annotations
{
    public class AddProductValidator : AbstractBaseValidator<AddProductRequest>
    {
        public AddProductValidator()
        {
            RuleFor(x => x.Price).GreaterThan(0);
            RuleFor(x => x.ProductName).NotEmpty();
        }
    }
}
