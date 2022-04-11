using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherWebSiteApp.Services
{
    public interface ICryptographer 
    {
        public string GetHashString(string s);
    }
}
