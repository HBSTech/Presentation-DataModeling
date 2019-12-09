using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baseline.Models.NEWCC
{
    [Serializable]
    public class BannerHero : IHeroBanner
    {

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
        public string Url { get; set; }

        public BannerHero()
        {

        }
        public string BannerType()
        {
            return "BannerHero";
        }

        public string RenderHtml()
        {
            return $"<div class='BannerHero'><a href='{Url}'><img src='{ImageUrl}' alt='{AltText.Replace("\'", "\\\'")}'/></a></div>";
        }
    }
}