using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SessionManager.Data;
using SessionManager.Services;
using System;
using System.Threading.Tasks;

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
            addAlignments();
        }

        static void SetupServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<SessionManagerDbContext>(
                options => options.UseSqlServer(local));
            services.AddScoped<ICharacterData, SqlCharacterData>();
            services.AddScoped<IRaceData, SqlRaceData>();
            services.AddScoped<IAlignmentData, SqlAlignmentData>();
            var provider = services.BuildServiceProvider();

            _dbContext = provider.GetService<SessionManagerDbContext>();
        }

        static string local = "Server=(localdb)\\MSSQLLocalDB;Database=SessionManager;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static string Local { get => local; set => local = value; }

        static void addRaces()
        {
            IRaceData _raceData = new SqlRaceData(_dbContext);

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Human",
                Size = SessionManager.Models.Size.Medium,
                Speed = 30
            });

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Dragonborn",
                Size = SessionManager.Models.Size.Medium,
                Speed = 30
            });

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Dwarf",
                Size = SessionManager.Models.Size.Medium,
                Speed = 25
            });

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Elf",
                Size = SessionManager.Models.Size.Medium,
                Speed = 30
            });

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Gnome",
                Size = SessionManager.Models.Size.Small,
                Speed = 30
            });

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Half Elf",
                Size = SessionManager.Models.Size.Medium,
                Speed = 30
            });

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Half Orc",
                Size = SessionManager.Models.Size.Medium,
                Speed = 30
            });

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Halfling",
                Size = SessionManager.Models.Size.Small,
                Speed = 25
            });

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Tiefling",
                Size = SessionManager.Models.Size.Medium,
                Speed = 30
            });
        }

        static void addAlignments()
        {
            IAlignmentData _alignmentData = new SqlAlignmentData(_dbContext);

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Lawful Good"
            });

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Neutral Good"
            });

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Chaotic Good"
            });

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Lawful Neutral"
            });

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Neutral"
            });

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Chaotic Neutral"
            });

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Lawful Evil"
            });

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Neutral Evil"
            });

            _alignmentData.Add(new SessionManager.Models.Alignment
            {
                Name = "Chaotic Evil"
            });
        }
    }
}
