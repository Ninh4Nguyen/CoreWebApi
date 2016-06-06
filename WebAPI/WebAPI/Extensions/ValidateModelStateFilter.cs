using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebAPI.Models.API;

namespace WebAPI.Extensions
{
    public class ValidateModelStateFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                var validationResults = actionContext.ModelState.ToValidationResults();
                var errorMessage = validationResults.Any() ? validationResults.First().Errors.First() : "Data Invalid";
                var response = Response.Fail(errorMessage);
                actionContext.Response = actionContext.Request.CreateResponse<Response>(HttpStatusCode.OK, response);
            }
        }
    }
}
