using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SessionManager.Services;
using SessionManager.Models;
using System.Collections.Generic;

namespace SessionManager.Pages.Characters
{
    public class EditModel : PageModel
    {
        private ICharacterData _characterData;
        private IRaceData _raceData;
        public IEnumerable<Race> Races;

        [BindProperty]
        public Character Character { get; set; }

        public EditModel(ICharacterData characterData, IRaceData raceData)
        {
            _characterData = characterData;
            _raceData = raceData;

            Races = _raceData.GetAll();
        }

        public IActionResult OnGet(int id)
        {
            Character = _characterData.Get(id);
            if(Character == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _characterData.Update(Character);
                return RedirectToAction("Details", "Character", new { id = Character.Id });
            }
            return Page();
        }
    }
}