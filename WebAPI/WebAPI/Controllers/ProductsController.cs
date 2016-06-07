using DAL;
using DAL.Entities;
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
        public IEnumerable<AddProductRequest> GetAll()
        {
            var result = new List<AddProductRequest>();
            result.Add(new AddProductRequest()
            {
                ProductName = "iMac",
                Price = 2000,
            });

            result.Add(new AddProductRequest()
            {
                ProductName = "iPhone 6S",
                Price = 1050,
            });

            result.Add(new AddProductRequest()
            {
                ProductName = "Macbook",
                Price = 1500,
            });

            result.Add(new AddProductRequest()
            {
                ProductName = "Novo LX",
                Price = 800,
            });

            return result;
        }

        /// <summary>
        /// Get a product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public AddProductRequest GetProduct(int id)
        {
            return new AddProductRequest()
            {
                ProductName = "iMac",
                Price = 2000,
            };
        }

        /// <summary>
        /// Add a product
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public Response AddProduct(AddProductRequest request)
        {
            var db = new WebApiContext();
            var product = new Product()
            {
                ProductName = request.ProductName,
                Price = request.Price,
                ProductImage = request.ProductImage,
                Description = request.Description
            };

            db.Products.Add(product);
            var success = db.SaveChanges() > 0;

            return success ? 
                    Response.Succeed().AddData(product) : 
                    Response.Fail();
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
