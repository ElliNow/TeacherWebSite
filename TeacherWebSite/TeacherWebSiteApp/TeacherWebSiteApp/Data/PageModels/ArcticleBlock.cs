using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherWebSiteApp.Data.Models;

namespace TeacherWebSiteApp.Data.PageModels
{
    public class ArcticleBlock : Entity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public byte[]? Image { get; set; }
        public string? Video { get; set; }
        
        public Article Article { get; set; }
        public int ArticleId { get; set; }

    }
}
