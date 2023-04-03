using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middlewares.Middleware
{
    public class RequestEditingMiddleware
    {
        RequestDelegate _requestDelegate;

        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            //ysk.com.tr/bilal
            if (context.Request.Path.ToString() == "/bilal")
            {
                await context.Response.WriteAsync("Welcome Bilal");
            }
            else
            {
                await _requestDelegate(context);
            }
        }
    }
}
