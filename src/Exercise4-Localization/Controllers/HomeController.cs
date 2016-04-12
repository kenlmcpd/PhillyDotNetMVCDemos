using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Localization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercise4_Localization.Controllers
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
            ViewData["Message"] = _localizer["Hi." + CultureInfo.CurrentCulture].Value;
            return View();
        }

        
        
    }
}
