
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers.Canada
{
    [Locale("en-CA")]
    public class OrdersControlller : Controller
    {
        public string Index()
        {
            return "Hello from Canada.";
        }
    }
}