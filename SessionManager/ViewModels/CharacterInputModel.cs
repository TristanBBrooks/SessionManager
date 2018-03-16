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
        public Subrace Subrace { get; set; }

        [Required]
        public Alignment Alignment { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public int Experience { get; set; }

        public IEnumerable<Subrace> Subraces { get; set; }

        public IEnumerable<Alignment> Alignments { get; set; }
    }
}
