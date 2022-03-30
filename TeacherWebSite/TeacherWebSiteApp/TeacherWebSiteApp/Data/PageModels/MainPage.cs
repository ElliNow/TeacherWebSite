using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherWebSiteApp.Data.Models;

namespace TeacherWebSiteApp.Data.PageModels
{
    public class MainPage : Entity
    {
        public bool IsActiveProfile { get; set; }
        public string Name { get; set; }
        public string? BigPictureTitle { get; set; }
        public string? BigPictureText { get; set; }
        public byte[]? BigPictureData { get; set; }
        public bool IsBannerEnabled { get; set; }

        public bool IsCardsEnabled { get; set; }
        public string? Link1Text { get; set; }
        public string? Link1Sourse { get; set; }
        public string? Block1Title { get; set; }
        public string? Block1Text { get; set; }
        public byte[]? Block1Data { get; set; }

        public string? Link2Text { get; set; }
        public string? Link2Sourse { get; set; }
        public string? Block2Title { get; set; }
        public string? Block2Text { get; set; }
        public byte[]? Block2Data { get; set; }

        public string? Link3Text { get; set; }
        public string? Link3Sourse { get; set; }
        public string? Block3Title { get; set; }
        public string? Block3Text { get; set; }
        public byte[]? Block3Data { get; set; }

        public bool IsSliderEnabled { get; set; }
        public virtual IList<SliderPicture> SliderPictures { get; set; }
    }
}
