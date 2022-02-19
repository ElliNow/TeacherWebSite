using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherWebSiteApp.Data.Models
{
    public class Publication : Entity
    {
        public string Name { get; set; }
        public string Text { get; set; }
        //public byte[]? Image { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Attachment> Attachments { get; set; }

    }
}
