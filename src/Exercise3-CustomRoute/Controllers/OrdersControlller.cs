
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers
{
    public class OrdersControlller : Controller
    {
        [HttpGet("Orders/{id}")]
        public string Index(int id)
        {
            return "Hello from " + RouteData.Values["locale"] + ".";
        }
    }
}
