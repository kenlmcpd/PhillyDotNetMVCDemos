
using Microsoft.AspNet.Mvc;

namespace CustomRouteDemo.Controllers.Spain
{
    [Locale("es-ES")]
    public class ProductsController : Controller
    {
        public string Index()
        {
            return "<h1>Productos</h1>Hola from Spain.";
        }
    }
}