using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherWebSiteApp.Data.Models
{
    public class GroupPublication : Entity
    {
        public string? Name { get; set; }

        public Group Group { get; set; }
        public int GroupId { get; set; }
        public Publication Publication { get; set; }
        public int PublicationId { get; set; }
    }
}
