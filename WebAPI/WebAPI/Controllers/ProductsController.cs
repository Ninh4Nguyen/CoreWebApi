using System.Collections.Generic;
using System.Web.Http;
using Utilities.Helpers;
using WebAPI.Models.API;

namespace WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            var result = new List<Product>();
            result.Add(new Product()
            {
                ProductId = 1101,
                ProductName = "iMac",
                Price = 2000,
                ProductType = CommonEnum.ProductTypes.Luxury,
            });

            result.Add(new Product()
            {
                ProductId = 1101,
                ProductName = "iPhone 6S",
                Price = 1050,
                ProductType = CommonEnum.ProductTypes.Luxury,
            });

            result.Add(new Product()
            {
                ProductId = 1101,
                ProductName = "Macbook",
                Price = 1500,
                ProductType = CommonEnum.ProductTypes.Luxury,
            });

            result.Add(new Product()
            {
                ProductId = 1101,
                ProductName = "Novo LX",
                Price = 800,
                ProductType = CommonEnum.ProductTypes.Normal,
            });

            return result;
        }

        /// <summary>
        /// Get a product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Product GetProduct(int id)
        {
            return new Product()
            {
                ProductId = 1101,
                ProductName = "iMac",
                Price = 2000,
                ProductType = CommonEnum.ProductTypes.Luxury,
            };
        }

        /// <summary>
        /// Add a product
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void AddProduct(Product p)
        {
        }

        /// <summary>
        /// Delete a product
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
