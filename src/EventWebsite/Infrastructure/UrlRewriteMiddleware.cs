using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace EventWebsite.Infrastructure
{
    public class UrlRewriteMiddleware
    {
        readonly RequestDelegate _next;
        Predicate<HttpContext> _eval;
        Func<HttpContext, string> _location;

        public UrlRewriteMiddleware(RequestDelegate nextHandler, Predicate<HttpContext> eval, Func<HttpContext, string> location)
        {
            _next = nextHandler;
            _eval = eval;
            _location = location;
        }

        public async Task Invoke(HttpContext context)
        {
            if (_eval(context))
                context.Response.Redirect(_location(context));
            else
                await _next(context);
        }
    }
}
