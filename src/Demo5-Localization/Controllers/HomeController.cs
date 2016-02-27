

using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Globalization;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.OptionsModel;

namespace Demo5_Localization.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHtmlLocalizer _localizer;

        public HomeController(IHtmlLocalizer<HomeController> localizer)
        {
            _localizer = localizer;            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Localization()
        {
            var result = _localizer["LearnMore2"];
            ViewData["Message"] = result;          
            return View();
        }

        string LearnMore2 = "testing";
    }
}
