using Microsoft.AspNetCore.Mvc;
using SessionManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManager.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();

            return View(model);
        }
    }
}
