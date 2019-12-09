using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baseline.Models.NEWCC
{
    [Serializable]
    public class HeroBanners
    {
        public HeroBanners() { }

        public List<HeroBanner> Banners { get; set; }
    }

    [Serializable]
    public class HeroBanner
    {
        public IHeroBanner Banner { get; set; }

        public string BannerType
        {
            get
            {
                return Banner.BannerType();
            }
        }
    }
}