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
        public Publication Publication { get; set; }
        public int PublicationId { get; set; }
        public ContentType ContentType { get; set; }
    }

    public enum ContentType
    {
        Presentation,
        HandBook,
        Video
    }
}
