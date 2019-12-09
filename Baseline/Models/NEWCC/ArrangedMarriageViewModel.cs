using CMS.DocumentEngine.Types.NEWCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baseline.Models.NEWCC
{
    public class ArrangedMarriageViewModel
    {
        public ArrangedMarriageViewModel() {
            Tires = new List<CarPart>();
            Rims = new List<CarPart>();
        }

        public string CarTitle { get; set; }

        public List<CarPart> Tires { get; set; }
        public List<CarPart> Rims { get; set; }
    }
}