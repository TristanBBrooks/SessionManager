using SessionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManager.Services
{
    public interface IClassData
    {
        IEnumerable<Class> GetAll();
        Class Get(int id);
        Class Add(Class _class);
        Class Update(Class _class);
    }
}
