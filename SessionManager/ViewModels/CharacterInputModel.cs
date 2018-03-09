using SessionManager.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SessionManager.ViewModels
{
    public class CharacterInputModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public Race Race { get; set; }

        [Required]
        public Alignment Alignment { get; set; }

        public IEnumerable<Race> Races { get; set; }
    }
}
