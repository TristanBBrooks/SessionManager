using System.Collections.Generic;
using System.Linq;
using SessionManager.Models;
using SessionManager.Data;
using Microsoft.EntityFrameworkCore;

namespace SessionManager.Services
{
    public class SqlClassData : IClassData
    {
        private SessionManagerDbContext _context;

        public SqlClassData(SessionManagerDbContext context)
        {
            _context = context;
        }
                
        public Class Add(Class _class)
        {
            _context.Classes.Add(_class);
            _context.SaveChanges();

            return _class;
        }

        public Class Get(int id)
        {
            return _context.Classes
                .FirstOrDefault(_ => _.Id == id);
        }

        public IEnumerable<Class> GetAll()
        {
            return _context.Classes
                .OrderBy(_ => _.Name).ToList();
        }

        public Class Update(Class _class)
        {
            _context.Attach(_class).State = EntityState.Modified;
            _context.SaveChanges();

            return _class;
        }
    }
}
