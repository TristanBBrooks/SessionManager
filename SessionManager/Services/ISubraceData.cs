using SessionManager.Models;
using System.Collections.Generic;

namespace SessionManager.Services
{
    public interface ISubraceData
    {
        IEnumerable<Subrace> GetAll();
        IEnumerable<Subrace> GetAllPlayable();
        Subrace Get(int id);
        Subrace Add(Subrace subrace);
        Subrace Update(Subrace subrace);
    }
}
