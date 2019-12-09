using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baseline.Models.NEWCC
{
    [Serializable]
    public class CTAHero : IHeroBanner
    {

        public string Name { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string CallToAction { get; set; }
        public string Url { get; set; }

        public CTAHero()
        {

        }
        public string BannerType()
        {
            return "CTAHero";
        }

        public string RenderHtml()
        {
            return $"<div class=\"CTAHero\" style=\"background-image: url('{BackgroundImageUrl}');\"><a class='btn btn-primary' href='{Url}'>{CallToAction}</a></div>";
        }
    }
}