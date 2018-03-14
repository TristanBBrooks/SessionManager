using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SessionManager.Data;
using SessionManager.Models;
using SessionManager.Services;
using SessionManager.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SessionManager.Controllers
{
    [Authorize]
    public class CharacterController : Controller
    {
        private ICharacterData _characterData;
        private IRaceData _raceData;

        public CharacterController(ICharacterData characterData, IRaceData raceData)
        {
            _characterData = characterData;
            _raceData = raceData;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = new CharacterIndexViewModel();
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
            var model = new CharacterInputModel()
            {
                Races = _raceData.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CharacterEditModel model)
        {
            if (ModelState.IsValid)
            {
                var races = _raceData.GetAll();
                var modelRace = races.First(_ => _.Id == model.Race);

                var newCharacter = new Character()
                {
                    Name = model.Name,
                    Alignment = model.Alignment,
                    Race = modelRace,
                    Level = model.Level,
                    Experience = model.Experience,
                    Speed = modelRace.Speed
                };

                newCharacter = _characterData.Add(newCharacter);

                return RedirectToAction(nameof(Details), new { id = newCharacter.Id });
            }
            else
            {
                var viewModel = new CharacterInputModel()
                {
                    Races = _raceData.GetAll()
                };

                return View(viewModel);
            }
        }
    }
}
