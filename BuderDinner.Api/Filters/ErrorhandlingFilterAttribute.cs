using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace BuderDinner.Api.Filters
{
    public class ErrorhandlingFilterAttribute :ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var proplemdetail = new ProblemDetails
            {
                Title = "co loi trong qua trinh xu ly",
                Status = (int)HttpStatusCode.InternalServerError,
            };
            context.Result = new ObjectResult(proplemdetail);
            
            context.ExceptionHandled = true; 
        }
    }
}
