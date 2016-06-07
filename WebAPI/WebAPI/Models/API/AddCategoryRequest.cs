using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models.API
{
    public class AddCategoryRequest
    {
        /// <summary>
        /// The name of category
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// The description of category 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The image of category
        /// </summary>
        public string Image { get; set; }
    }
}
