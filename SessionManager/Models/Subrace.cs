namespace SessionManager.Models
{
    public class Subrace
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Race Race { get; set; }

        public Size Size { get; set; }

        public int Speed { get; set; }

        public bool Playable { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Intelligence { get; set; }

        public int Wisdom { get; set; }

        public int Charisma { get; set; }
    }
}