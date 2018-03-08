using System.Collections.Generic;

namespace SessionManager.Models
{
    public class Race
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public Subrace Subrace { get; set; }

        //public AbilityScores AbilityScores { get; set; }

        public Size Size { get; set; }

        public int Speed { get; set; }

        //public Proficiencies Proficiencies { get; set; }

        //public IEnumerable<Language> Languages { get; set; }

        //public IEnumerable<Trait> Traits { get; set; }
    }
}