using CMS.DocumentEngine.Types.NEWCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baseline.Models.NEWCC
{
    public class KissingCousinsViewModel
    {
        public List<IHeroBanner> Banners {get; set;}
        public string PageName { get; set; }
        public KissingCousinsViewModel() { }
    }
}