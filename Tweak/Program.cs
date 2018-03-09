using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SessionManager.Data;
using SessionManager.Services;
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
            IRaceData _raceData = new SqlRaceData(_dbContext);

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Human",
                Size = SessionManager.Models.Size.Medium,
                Speed = 30
            });
        }

        static void SetupServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<SessionManagerDbContext>(
                options => options.UseSqlServer(local));
            services.AddScoped<ICharacterData, SqlCharacterData>();
            services.AddScoped<IRaceData, SqlRaceData>();
            var provider = services.BuildServiceProvider();

            _dbContext = provider.GetService<SessionManagerDbContext>();
        }

        static string local = "Server=(localdb)\\MSSQLLocalDB;Database=SessionManager;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static string Local { get => local; set => local = value; }
    }
}
