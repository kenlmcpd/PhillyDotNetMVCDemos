
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers.US
{
    [Locale("en-US")]
    public class ProductsController : Controller
    {
        public string Index()
        {
            return "Hello from the USA.";
        }
    }
}