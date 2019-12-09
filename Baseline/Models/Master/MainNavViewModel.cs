using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baseline.Models.Master
{
    public class MainNavViewModel
    {
        public IEnumerable<MainNavItem> NavItems { get; set; }
        public MainNavViewModel() { }
    }
}