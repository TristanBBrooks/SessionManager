using SessionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManager.Services
{
    public interface IAlignmentData
    {
        IEnumerable<Alignment> GetAll();
        Alignment Get(int id);
        Alignment Add(Alignment alignment);
        Alignment Update(Alignment alignment);
    }
}
