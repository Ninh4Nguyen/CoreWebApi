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
        public double? Price { get; set; }

        /// <summary>
        /// The image of product
        /// </summary>
        public string ProductImage { get; set; }

        /// <summary>
        /// The description of product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The category indentify of product
        /// </summary>
        public int? CategoryId { get; set; }
    }
}
