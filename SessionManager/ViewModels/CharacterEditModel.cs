using SessionManager.Models;
using System.ComponentModel.DataAnnotations;

namespace SessionManager.ViewModels
{
    public class CharacterEditModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Class { get; set; }

        [Required]
        public int Subrace { get; set; }

        [Required]
        public int Alignment { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public int Experience { get; set; }
    }
}
