using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SessionManager.Data;
using SessionManager.Services;
using System.Threading.Tasks;

namespace ScriptPad.Tweak
{
    partial class Program
    {
        static void Main(string[] args) => MainAsync(args).GetAwaiter().GetResult();
#pragma warning disable 1998
        static async Task MainAsync(string[] args)
        {
            await AddTestEntities();
        }

        static SessionManagerDbContext _dbContext;
         

        static async Task AddTestEntities()
        {
            IRaceData _raceData = new SqlRaceData(_dbContext);

            _raceData.Add(new SessionManager.Models.Race
            {
                Name = "Dwarf",
                Size = SessionManager.Models.Size.Medium,
                Speed = 30
            });
        }

        static void SetupServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<SessionManagerDbContext>(
                options => options.UseSqlServer("(localdb)\\MSSQLLocalDB; Database = SessionManager; Trusted_Connection = True; MultipleActiveResultSets = true"));
            services.AddScoped<ICharacterData, SqlCharacterData>();
            services.AddScoped<IRaceData, SqlRaceData>();
            var provider = services.BuildServiceProvider();

            _dbContext = provider.GetService<SessionManagerDbContext>();
        }
    }
}
