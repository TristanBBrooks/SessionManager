﻿using Microsoft.EntityFrameworkCore;
using SessionManager.Models;

namespace SessionManager.Data
{
    public class SessionManagerDbContext : DbContext
    {
        public SessionManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Alignment> Alignments { get; set; }
    }
}
