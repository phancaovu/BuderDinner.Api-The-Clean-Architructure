using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BuderDinner.Api.Middleware
{
    public class ErroshandlingMiddleware
    {
        private readonly RequestDelegate _next;
       
        public ErroshandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }catch (Exception ex)
            {
                await HandleExceptionErros(context, ex);
            }
        }

        private Task HandleExceptionErros(HttpContext context, Exception ex)
        {
            var code = HttpStatusCode.InternalServerError; //500 if unexpective
            var result = JsonSerializer.Serialize(new { error = "da  xay ra loi xư lý trong khi " });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;    
            return context.Response.WriteAsync(result);
        }
    }
}
