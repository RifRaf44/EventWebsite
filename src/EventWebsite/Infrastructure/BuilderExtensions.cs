using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace EventWebsite.Infrastructure
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseUrlRewriter(this IApplicationBuilder app, Predicate<HttpContext> eval, Func<HttpContext, string> location)
        {
            return app.UseMiddleware<UrlRewriteMiddleware>(eval, location);
        }
    }
}
