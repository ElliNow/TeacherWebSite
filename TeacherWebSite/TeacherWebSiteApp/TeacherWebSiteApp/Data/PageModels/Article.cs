using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherWebSiteApp.Data.Models;

namespace TeacherWebSiteApp.Data.PageModels
{
    public class Article : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public List<ArcticleBlock> Blocks { get; set; }
    }
}
