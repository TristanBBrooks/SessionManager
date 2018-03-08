using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SessionManager.Models;
using SessionManager.Data;
using Microsoft.EntityFrameworkCore;

namespace SessionManager.Services
{
    public class SqlRaceData : IRaceData
    {
        private SessionManagerDbContext _context;

        public SqlRaceData(SessionManagerDbContext context)
        {
            _context = context;
        }

        public Race Add(Race race)
        {
            _context.Races.Add(race);
            _context.SaveChanges();

            return race;
        }

        public Race Get(int id)
        {
            return _context.Races.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Race> GetAll()
        {
            return _context.Races.OrderBy(r => r.Name);
        }

        public Race Update(Race race)
        {
            _context.Attach(race).State = EntityState.Modified;
            _context.SaveChanges();

            return race;
        }
    }
}
