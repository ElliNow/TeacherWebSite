using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherWebSiteApp.Data.Models
{
    public class Group : Entity
    {
        public string Name { get; set; }
        public int CourseNumb { get; set; }
    }
}
