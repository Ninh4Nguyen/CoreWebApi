using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helpers;
using Utilities.Extensions;

namespace WebAPI.Models.API
{
    public class Response
    {
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public ExpandoObject Data { get; set; }

        public static Response Create(int statusCode, bool success, string message = "")
        {
            return new Response()
            {
                StatusCode = statusCode,
                Success = success,
                Message = message,
                Data = new ExpandoObject()
            };
        }

        public static Response Succeed(string message = "Succeed")
        {
            return Create(CommonEnum.StatusCodeType.OK.GetHashCode(), true, message);
        }

        public static Response Fail(string message = "Fail")
        {
            return Create(CommonEnum.StatusCodeType.InValid.GetHashCode(), false, message);
        }

        public Response AddData(string key, object value)
        {
            if(Data == null)
            {
                throw new NullReferenceException("Data");
            }

            Data.AddProperties(key, value);

            return this;
        }

        public Response AddData(object value)
        {
            Data = value.ToDynamic();

            return this;
        }
    }
}
