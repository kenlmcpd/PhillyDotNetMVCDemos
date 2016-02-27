
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;

namespace CustomRouteDemo
{
    public class LocalizedRoute : IRouter
    {
        private readonly IRouter _next;

        private readonly Dictionary<string, string> _users = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "Javier", "es-ES" },
            { "Rob", "en-CA" },
            { "Ken", "en-US" },
        };

        public LocalizedRoute(IRouter next)
        {
            _next = next;
        }

        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            // We just want to act as a pass-through for link generation
            return _next.GetVirtualPath(context);
        }

        public async Task RouteAsync(RouteContext context)
        {
            context.RouteData.Routers.Add(_next);

            var locale = GetLocale(context.HttpContext) ?? "en-US";
            context.RouteData.Values.Add("locale", locale);

            await _next.RouteAsync(context);
        }

        private string GetLocale(HttpContext context)
        {
            string locale;
            _users.TryGetValue(context.Request.Headers["User"], out locale);
            return locale;
        }
    }
}