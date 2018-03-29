using System.Collections.Generic;

namespace SessionManager.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Subrace Subrace { get; set; }

        public Alignment Alignment { get; set; }

        public int Experience { get; set; }

        public int Level { get; set; }

        public Class Class { get; set; } 

        //public IEnumerable<Proficiency> Proficiencies { get; set; }

        //public IEnumerable<Spell> Spells { get; set; }

        //public IEnumerable<Feat> Feats { get; set; }

        //public Inventory Inventory { get; set; }

        public int Speed { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Intelligence { get; set; }

        public int Wisdom { get; set; }

        public int Charisma { get; set; }
    }
}
