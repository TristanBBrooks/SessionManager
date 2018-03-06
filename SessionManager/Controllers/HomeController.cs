using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SessionManager.Models;
using SessionManager.Services;
using SessionManager.ViewModels;

namespace SessionManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ICharacterData _characterData;

        public HomeController(ICharacterData characterData)
        {
            _characterData = characterData;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Characters = _characterData.GetAll();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _characterData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CharacterEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newCharacter = new Character()
                {
                    Name = model.Name,
                    Alignment = model.Alignment,
                    Race = model.Race
                };

                newCharacter = _characterData.Add(newCharacter);

                return RedirectToAction(nameof(Details), new { id = newCharacter.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
