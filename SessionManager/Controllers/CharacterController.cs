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
        private IAlignmentData _alignmentData;
        private ISubraceData _subraceData;

        public CharacterController(ICharacterData characterData,
            IRaceData raceData,
            IAlignmentData alignmentData,
            ISubraceData subraceData)
        {
            _characterData = characterData;
            _raceData = raceData;
            _alignmentData = alignmentData;
            _subraceData = subraceData;
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
                Subraces = _subraceData.GetAllPlayable(),
                Alignments = _alignmentData.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CharacterEditModel model)
        {
            if (ModelState.IsValid)
            {
                var subrace = _subraceData.Get(model.Subrace);
                var alignment = _alignmentData.Get(model.Alignment);
                

                var newCharacter = new Character()
                {
                    Name = model.Name,
                    Alignment = alignment,
                    Subrace = subrace,
                    Level = model.Level,
                    Experience = model.Experience,
                    Speed = subrace.Speed
                };

                newCharacter = _characterData.Add(newCharacter);

                return RedirectToAction(nameof(Details), new { id = newCharacter.Id });
            }
            else
            {
                var viewModel = new CharacterInputModel()
                {
                    Subraces = _subraceData.GetAllPlayable()
                };

                return View(viewModel);
            }
        }
    }
}
