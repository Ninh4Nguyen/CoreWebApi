using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Extensions
{
    public static class ModelStateExtensions
    {
        public static IEnumerable<ValidationResult> ToValidationResults(this System.Web.Http.ModelBinding.ModelStateDictionary modelState)
        {
            return modelState.Select(x => new ValidationResult
            {
                FieldName = x.Key,
                FieldValue = x.Value != null ? x.Value.Value != null ? x.Value.Value.AttemptedValue : null : null,
                Errors = x.Value != null ? x.Value.Errors.Select(e => e.ErrorMessage).ToArray() : null
            }).ToList();
        }
    }

    public class ValidationResult
    {
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public string[] Errors { get; set; }
    }
}
