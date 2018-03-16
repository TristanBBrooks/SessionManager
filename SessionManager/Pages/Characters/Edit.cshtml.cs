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
        private ISubraceData _subraceData;
        private IAlignmentData _alignmentData;
        public IEnumerable<Subrace> Subraces;
        public IEnumerable<Alignment> Alignments;

        [BindProperty]
        public Character Character { get; set; }

        public EditModel(ICharacterData characterData, ISubraceData subraceData, IAlignmentData alignmentData)
        {
            _characterData = characterData;
            _subraceData = subraceData;
            _alignmentData = alignmentData;

            Subraces = _subraceData.GetAllPlayable();
            Alignments = _alignmentData.GetAll();
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