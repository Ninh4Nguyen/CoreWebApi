using FluentValidation.Attributes;
using Utilities.Helpers;
using WebAPI.Models.Annotations;

namespace WebAPI.Models.API
{
    [Validator(typeof(AddProductValidator))]
    public class AddProductRequest
    {
        /// <summary>
        /// The name of product
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// The price of product
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// The type which product belong to
        /// </summary>
        public CommonEnum.ProductTypes ProductType { get; set; }
    }
}
