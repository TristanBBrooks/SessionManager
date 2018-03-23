using System.Collections.Generic;

namespace SessionManager.Models
{
    public class Race
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Subrace> Subraces { get; set; }

        //public AbilityScores AbilityScores { get; set; }

        //public IEnumerable<Proficiency> Proficiencies { get; set; }

        //public IEnumerable<Language> Languages { get; set; }

        //public IEnumerable<Trait> Traits { get; set; }
    }
}