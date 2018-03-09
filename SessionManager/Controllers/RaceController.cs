using Microsoft.AspNetCore.Mvc;
using SessionManager.Services;
using SessionManager.ViewModels;

namespace SessionManager.Controllers
{
    public class RaceController : Controller
    {
        private IRaceData _raceData;

        public RaceController(IRaceData raceData)
        {
            _raceData = raceData;
        }

        public IActionResult Index()
        {
            var model = new RaceIndexViewModel();
            model.Races = _raceData.GetAll();

            return View(model);
        }
    }
}
