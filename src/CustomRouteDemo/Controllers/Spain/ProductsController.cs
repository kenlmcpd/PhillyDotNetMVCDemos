
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers.Spain
{
    [Locale("es-ES")]
    public class ProductsController : Controller
    {
        public string Index()
        {
            return "Hola from Spain.";
        }
    }
}