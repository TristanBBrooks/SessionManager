using SessionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManager.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Character> Characters { get; set; }
    }
}
