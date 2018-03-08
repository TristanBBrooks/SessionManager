using SessionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManager.Services
{
    public interface IRaceData
    {
        IEnumerable<Race> GetAll();
        Race Get(int id);
        Race Add(Race race);
        Race Update(Race race);
    }
}
