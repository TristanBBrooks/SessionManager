using Microsoft.EntityFrameworkCore;
using SessionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManager.Data
{
    public class SessionManagerDbContext : DbContext
    {
        public SessionManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
    }
}
