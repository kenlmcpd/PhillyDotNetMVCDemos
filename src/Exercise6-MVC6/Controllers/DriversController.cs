using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using Demo7_MVC6.Models;

namespace Demo7_MVC6.Controllers
{
    public class DriversController : Controller
    {
        public DriversController(IOptions<AppSettings> appSettings)
        {
            

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
