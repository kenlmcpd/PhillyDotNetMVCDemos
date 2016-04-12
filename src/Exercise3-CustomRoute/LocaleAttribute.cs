using Microsoft.AspNet.Mvc.Infrastructure;
using Microsoft.AspNet.Mvc.Routing;

namespace CustomRouteDemo
{
    public class LocaleAttribute : RouteConstraintAttribute
    {
        public LocaleAttribute(string locale)
            : base("locale", routeValue: locale, blockNonAttributedActions: true)
        {
        }
    }
}