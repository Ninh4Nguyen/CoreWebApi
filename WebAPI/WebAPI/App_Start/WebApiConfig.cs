using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FluentValidation.WebApi;
using WebAPI.Extensions;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new ValidateModelStateFilter());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Fluent Validation
            FluentValidationModelValidatorProvider.Configure(config);
        }
    }
}
