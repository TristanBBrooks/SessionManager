using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SessionManager.Data;
using SessionManager.Models;
using SessionManager.Services;

namespace ScriptPad.Tweak
{
    partial class Program
    {
        static void Main(string[] args)
        {
            SetupServices();
            AddTestEntities();
        }

        static SessionManagerDbContext _dbContext;
         

        static void AddTestEntities()
        {
            //addRaces();
            //addAlignments();
            addClasses();
        }

        static void addClasses()
        {
            IClassData _classData = new SqlClassData(_dbContext);

            _classData.Add(new Class
            {
                Name = "Barbarian"
            });

            _classData.Add(new Class
            {
                Name = "Bard"
            });

            _classData.Add(new Class
            {
                Name = "Cleric"
            });

            _classData.Add(new Class
            {
                Name = "Druid"
            });

            _classData.Add(new Class
            {
                Name = "Monk"
            });

            _classData.Add(new Class
            {
                Name = "Paladin"
            });

            _classData.Add(new Class
            {
                Name = "Ranger"
            });

            _classData.Add(new Class
            {
                Name = "Rogue"
            });

            _classData.Add(new Class
            {
                Name = "Sorcerer"
            });

            _classData.Add(new Class
            {
                Name = "Warlock"
            });

            _classData.Add(new Class
            {
                Name = "Wizard"
            });
        }

        static void SetupServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<SessionManagerDbContext>(
                options => options.UseSqlServer(local));
            services.AddScoped<ICharacterData, SqlCharacterData>();
            services.AddScoped<IRaceData, SqlRaceData>();
            services.AddScoped<IAlignmentData, SqlAlignmentData>();
            services.AddScoped<ISubraceData, SqlSubraceData>();
            services.AddScoped<IClassData, SqlClassData>();
            var provider = services.BuildServiceProvider();

            _dbContext = provider.GetService<SessionManagerDbContext>();
        }

        static string local = "Server=(localdb)\\MSSQLLocalDB;Database=SessionManager;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static string Local { get => local; set => local = value; }

        static void addRaces()
        {
            IRaceData _raceData = new SqlRaceData(_dbContext);
            ISubraceData _subraceData = new SqlSubraceData(_dbContext);

            // Ogre and all subraces
            var ogre = _raceData.Add(new Race
            {
                Name = "Ogre",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Ogre",
                Playable = false,
                Speed = 40,
                Size = Size.Large,
                Race = ogre
            });

            // Giant and all subraces
            var giant = _raceData.Add(new Race
            {
                Name = "Giant",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Giant",
                Playable = false,
                Speed = 40,
                Size = Size.Large,
                Race = giant
            });

            // Orc and all subraces
            var orc = _raceData.Add(new Race
            {
                Name = "Orc",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Orc",
                Playable = false,
                Speed = 30,
                Size = Size.Medium,
                Race = orc
            });

            // Human and all subraces
            var human = _raceData.Add(new Race
            {
                Name = "Human",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Human",
                Playable = true,
                Size = Size.Medium,
                Speed = 30,
                Race = human
            });

            // Dragonborn and all subraces
            var dragonborn = _raceData.Add(new Race
            {
                Name = "Dragonborn",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Black Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "Blue Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "Brass Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "Bronze Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "Copper Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "Gold Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "Green Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "Red Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "Silver Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            _subraceData.Add(new Subrace
            {
                Name = "White Dragonborn",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = dragonborn
            });

            // Dwarf and all subraces
            var dwarf = _raceData.Add(new Race
            {
                Name = "Dwarf",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Dwarf",
                Playable = true,
                Speed = 25,
                Size = Size.Medium,
                Race = dwarf
            });

            _subraceData.Add(new Subrace
            {
                Name = "Duergar Dwarf",
                Playable = true,
                Speed = 25,
                Size = Size.Medium,
                Race = dwarf
            });

            _subraceData.Add(new Subrace
            {
                Name = "Hill Dwarf",
                Playable = true,
                Speed = 25,
                Size = Size.Medium,
                Race = dwarf
            });

            _subraceData.Add(new Subrace
            {
                Name = "Mountain Dwarf",
                Playable = true,
                Speed = 25,
                Size = Size.Medium,
                Race = dwarf
            });

            // Elf and all subraces
            var elf = _raceData.Add(new Race
            {
                Name = "Elf",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Elf",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = elf
            });

            _subraceData.Add(new Subrace
            {
                Name = "High Elf",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = elf
            });

            _subraceData.Add(new Subrace
            {
                Name = "Wood Elf",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = elf
            });

            _subraceData.Add(new Subrace
            {
                Name = "Drow Elf",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = elf
            });

            // Gnome and all subraces
            var gnome = _raceData.Add(new Race
            {
                Name = "Gnome",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Gnome",
                Playable = true,
                Speed = 25,
                Size = Size.Medium,
                Race = gnome
            });

            _subraceData.Add(new Subrace
            {
                Name = "Forest Gnome",
                Playable = true,
                Speed = 25,
                Size = Size.Medium,
                Race = gnome
            });

            _subraceData.Add(new Subrace
            {
                Name = "Rock Gnome",
                Playable = true,
                Speed = 25,
                Size = Size.Medium,
                Race = gnome
            });

            _subraceData.Add(new Subrace
            {
                Name = "Deep Gnome",
                Playable = true,
                Speed = 25,
                Size = Size.Medium,
                Race = gnome
            });

            // Half Elf and all subraces
            var halfelf = _raceData.Add(new Race
            {
                Name = "Half Elf",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Half Elf",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = halfelf
            });

            // Half Orc and all subraces
            var halforc = _raceData.Add(new Race
            {
                Name = "Half Orc",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Half Orc",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = halforc
            });

            _subraceData.Add(new Subrace
            {
                Name = "Mountain Half Orc",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = halforc
            });

            _subraceData.Add(new Subrace
            {
                Name = "Grey Half Orc",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = halforc
            });

            _subraceData.Add(new Subrace
            {
                Name = "Half Orog",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = halforc
            });

            // Halfling and all subraces
            var halfling = _raceData.Add(new Race
            {
                Name = "Halfling",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Halfling",
                Playable = true,
                Speed = 25,
                Size = Size.Small,
                Race = halfling
            });
            
            _subraceData.Add(new Subrace
            {
                Name = "Lightfoot Halfling",
                Playable = true,
                Speed = 25,
                Size = Size.Small,
                Race = halfling
            });
            
            _subraceData.Add(new Subrace
            {
                Name = "Trickfinger Halfling",
                Playable = true,
                Speed = 25,
                Size = Size.Small,
                Race = halfling
            });
            
            _subraceData.Add(new Subrace
            {
                Name = "Wiseheart Halfling",
                Playable = true,
                Speed = 25,
                Size = Size.Small,
                Race = halfling
            });

            _subraceData.Add(new Subrace
            {
                Name = "Ghostwise Halfling",
                Playable = true,
                Speed = 25,
                Size = Size.Small,
                Race = halfling
            });

            _subraceData.Add(new Subrace
            {
                Name = "Stout Halfling",
                Playable = true,
                Speed = 25,
                Size = Size.Small,
                Race = halfling
            });

            // Tiefling and all subraces
            var tiefling = _raceData.Add(new Race
            {
                Name = "Tiefling",
            });

            _subraceData.Add(new Subrace
            {
                Name = "Tiefling",
                Playable = true,
                Speed = 30,
                Size = Size.Medium,
                Race = tiefling
            });
        }

        static void addAlignments()
        {
            IAlignmentData _alignmentData = new SqlAlignmentData(_dbContext);

            _alignmentData.Add(new Alignment
            {
                Name = "Lawful Good"
            });

            _alignmentData.Add(new Alignment
            {
                Name = "Neutral Good"
            });

            _alignmentData.Add(new Alignment
            {
                Name = "Chaotic Good"
            });

            _alignmentData.Add(new Alignment
            {
                Name = "Lawful Neutral"
            });

            _alignmentData.Add(new Alignment
            {
                Name = "Neutral"
            });

            _alignmentData.Add(new Alignment
            {
                Name = "Chaotic Neutral"
            });

            _alignmentData.Add(new Alignment
            {
                Name = "Lawful Evil"
            });

            _alignmentData.Add(new Alignment
            {
                Name = "Neutral Evil"
            });

            _alignmentData.Add(new Alignment
            {
                Name = "Chaotic Evil"
            });
        }
    }
}
