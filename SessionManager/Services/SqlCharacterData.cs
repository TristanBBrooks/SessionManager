using SessionManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SessionManager.Models;
using Microsoft.EntityFrameworkCore;

namespace SessionManager.Services
{
    public class SqlCharacterData : ICharacterData
    {
        private SessionManagerDbContext _context;

        public SqlCharacterData(SessionManagerDbContext context)
        {
            _context = context;
        }

        public Character Add(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();

            return character;
        }

        public Character Get(int id)
        {
            return _context.Characters.Include(_ => _.Race).FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Character> GetAll()
        {
            return _context.Characters.Include(_ => _.Race).OrderBy(r => r.Name);
        }

        public Character Update(Character character)
        {
            _context.Attach(character).State = EntityState.Modified;
            _context.SaveChanges();

            return character;
        }
    }
}
