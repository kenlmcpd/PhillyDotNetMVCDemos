using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNet.Mvc.Filters;
using Microsoft.Extensions.Logging;


namespace Demo7_MVC6.Services
{
    public interface ILoggingFilter
    {

    }
    public class LoggingFilter : ActionFilterAttribute, ILoggingFilter
    {
        private ILogger _logger;
        public LoggingFilter(ILogger<LoggingFilter> logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            var controllerName = actionContext.RouteData.Values["controller"];
            var actionName = actionContext.RouteData.Values["action"];
            var controller = actionContext.Controller;
            var http = actionContext.HttpContext;
            var ip = http.Connection.RemoteIpAddress;
            _logger.LogDebug("Startup info");
        }

        public override void OnActionExecuted(ActionExecutedContext actioncContext)
        {
            _logger.LogDebug("Log Completion info");
        }
    }
}
