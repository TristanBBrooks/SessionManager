using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManager.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Race Race { get; set; }

        public Alignment Alignment { get; set; }
    }
}
