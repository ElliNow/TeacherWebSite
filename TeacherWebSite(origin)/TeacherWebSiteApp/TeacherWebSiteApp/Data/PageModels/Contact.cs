using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherWebSiteApp.Data.Models;

namespace TeacherWebSiteApp.Data.PageModels
{
    public class Contact : Entity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string? Link { get; set; }
        public byte[] Badge { get; set; }

    }
}
