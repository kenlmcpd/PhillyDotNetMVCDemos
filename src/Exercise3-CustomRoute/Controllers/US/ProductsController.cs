
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers.US
{
   
    public class ProductsController : Controller
    {
        public string Index()
        {
            return "Hello from the USA.";
        }
    }
}