
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers.Canada
{
    [Locale("en-CA")]
    public class ProductsController : Controller
    {
        public string Index()
        {
            return "<h1>Products</h1>Hey from Canada.";
        }
    }
}