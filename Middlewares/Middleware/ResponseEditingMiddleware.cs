using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middlewares.Middleware
{
    public class ResponseEditingMiddleware
    {
        RequestDelegate _requestDelegate;

        public ResponseEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate.Invoke(context);
            if (context.Response.StatusCode == StatusCodes.Status404NotFound)
            {
                await context.Response.WriteAsync("The Page Not Found");
            }
        }
    }
}
