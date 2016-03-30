
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers
{
    public class HomeControlller : Controller
    {
        [HttpGet("")]
        public string Index(int id)
        {
            return "Hello from " + RouteData.Values["locale"] + ".";
        }
    }
}
