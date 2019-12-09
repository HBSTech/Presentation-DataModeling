using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baseline.Models.NEWCC
{
    public interface IHeroBanner
    {
        string BannerType();

        string RenderHtml();
    }
}