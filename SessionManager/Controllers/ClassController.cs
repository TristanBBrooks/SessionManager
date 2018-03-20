using Microsoft.AspNetCore.Mvc;
using SessionManager.Services;
using SessionManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManager.Controllers
{
    public class ClassController : Controller
    {
        private IClassData _classData;

        public ClassController(IClassData classData)
        {
            _classData = classData;          
        }

        public IActionResult Index()
        {
            var model = new ClassIndexViewModel();
            model.Classes = _classData.GetAll();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _classData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
