using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherWebSiteApp.Data.Models;

namespace TeacherWebSiteApp.Data.PageModels
{
    public class SliderPicture : Entity
    {
        public byte[] Data { get; set; }
        public int MainPageId { get; set; }
        public virtual MainPage MainPage { get; set; }
    }
}
