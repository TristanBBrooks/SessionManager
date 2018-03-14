using SessionManager.Models;
using System.ComponentModel.DataAnnotations;

namespace SessionManager.ViewModels
{
    public class CharacterEditModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Race { get; set; }

        [Required]
        public Alignment Alignment { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public int Experience { get; set; }
    }
}
