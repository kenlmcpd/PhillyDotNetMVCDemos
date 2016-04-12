
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers
{
    public class HomeControlller : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "<h1>Home</h1><p>Hello from " + RouteData.Values["locale"] + ".</p>";
        }
    }
}
