using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Models.API;

namespace WebAPI.Controllers
{
    public class CategoriesController : ApiController
    {
        /// <summary>
        /// Add a category
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Response AddCategory(AddCategoryRequest request)
        {
            var db = new WebApiContext();
            var category = new Category()
            {
                CategoryName = request.CategoryName,
                Image = request.Image,
                Description = request.Description
            };

            db.Categories.Add(category);
            var success = db.SaveChanges() > 0;

            return success ? 
                    Response.Succeed().AddData(category) : 
                    Response.Fail();
        }
    }
}
