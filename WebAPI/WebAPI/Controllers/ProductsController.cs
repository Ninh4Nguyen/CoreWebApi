using System.Collections.Generic;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public string GetProduct(int id)
        {
            return "value";
        }

        /// <summary>
        /// Add a product
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void AddProduct([FromBody]string value)
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
