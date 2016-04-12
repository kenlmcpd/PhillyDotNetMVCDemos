
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers.US
{
    [Locale("en-US")]
    public class ProductsController : Controller
    {
        public string Index()
        {
            return "<h1>Products</h1>Hello from the USA.";
        }
    }
}