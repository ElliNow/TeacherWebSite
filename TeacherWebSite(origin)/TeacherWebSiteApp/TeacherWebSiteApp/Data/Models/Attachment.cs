using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherWebSiteApp.Data.Models
{
    public class Attachment : Entity
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public ContentType ContentType { get; set; }
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
    }

    public enum ContentType
    {
        Presentation = 1,
        Video = 2,
        MethodicalBook = 3
    }
}
