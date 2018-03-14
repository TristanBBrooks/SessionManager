using System.Collections.Generic;

namespace SessionManager.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Race Race { get; set; }

        public Alignment Alignment { get; set; }

        //public AbilityScores AbilityScores { get; set; }

        public int Experience { get; set; }

        public int Level { get; set; }

        //public Class Class { get; set; } 

        //public Proficiencies Proficiencies { get; set; }

        //public IEnumerable<Spell> Spells { get; set; }

        //public IEnumerable<Feat> Feats { get; set; }

        //public Inventory Inventory { get; set; }

        public int Speed { get; set; }
    }
}
