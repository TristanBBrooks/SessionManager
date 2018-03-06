using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SessionManager.Services;
using SessionManager.Models;

namespace SessionManager.Pages.Characters
{
    public class EditModel : PageModel
    {
        private ICharacterData _characterData;

        [BindProperty]
        public Character Character { get; set; }

        public EditModel(ICharacterData characterData)
        {
            _characterData = characterData;
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
                return RedirectToAction("Details", "Home", new { id = Character.Id });
            }
            return Page();
        }
    }
}