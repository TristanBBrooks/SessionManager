using SessionManager.Models;
using System.ComponentModel.DataAnnotations;

namespace SessionManager.ViewModels
{
    public class CharacterEditModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public Race Race { get; set; }

        [Required]
        public Alignment Alignment { get; set; }
    }
}
