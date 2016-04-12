using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using Demo7_MVC6.Models;
using Demo7_MVC6.Services;

namespace Demo7_MVC6.Controllers
{
    [ServiceFilter(typeof(ILoggingFilter))]
    public class HomeController : Controller
    {
        public HomeController(IOptions<AppSettings> appSettings)
        {
            var test = appSettings.Value.SiteTitle;
            var test2 = test;
        }

        public IActionResult Index()
        {
            return View();
            //return new ContentResult() { Content = "THIS IS MY TEST" };
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
