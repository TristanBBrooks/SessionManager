using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SessionManager.Data;
using SessionManager.Models;

namespace SessionManager.Services
{
    public class SqlAlignmentData : IAlignmentData
    {
        private SessionManagerDbContext _context;

        public SqlAlignmentData(SessionManagerDbContext context)
        {
            _context = context;
        }

        public Alignment Add(Alignment alignment)
        {
            _context.Alignments.Add(alignment);
            _context.SaveChanges();

            return alignment;
        }

        public Alignment Get(int id)
        {
            return _context.Alignments.FirstOrDefault(_ => _.Id == id);
        }

        public IEnumerable<Alignment> GetAll()
        {
            return _context.Alignments.OrderBy(_ => _.Name);
        }

        public Alignment Update(Alignment alignment)
        {
            _context.Attach(alignment).State = EntityState.Modified;
            _context.SaveChanges();

            return alignment;
        }
    }
}
