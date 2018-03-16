using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SessionManager.Data;
using SessionManager.Models;

namespace SessionManager.Services
{
    public class SqlSubraceData : ISubraceData
    {
        private SessionManagerDbContext _context;

        public SqlSubraceData(SessionManagerDbContext context)
        {
            _context = context;
        }

        public Subrace Add(Subrace subrace)
        {
            _context.Subraces.Add(subrace);
            _context.SaveChanges();

            return subrace;
        }

        public Subrace Get(int id)
        {
            return _context.Subraces
                .Include(_ => _.Race)
                .FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Subrace> GetAll()
        {
            return _context.Subraces
                .Include(_ => _.Race)
                .OrderBy(r => r.Name).ToList();
        }

        public IEnumerable<Subrace> GetAllPlayable()
        {
            return _context.Subraces
                .Include(_ => _.Race)
                .Where(_ => _.Playable == true)
                .OrderBy(r => r.Name).ToList();
        }

        public Subrace Update(Subrace subrace)
        {
            _context.Attach(subrace).State = EntityState.Modified;
            _context.SaveChanges();

            return subrace;
        }
    }
}
