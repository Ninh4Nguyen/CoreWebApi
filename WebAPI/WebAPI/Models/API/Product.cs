using Utilities.Helpers;

namespace WebAPI.Models.API
{
    public class Product
    {
        /// <summary>
        /// The indentity of product
        /// </summary>
        public int ProductId { get; set; }
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
