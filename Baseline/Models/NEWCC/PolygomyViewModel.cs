using CMS.DocumentEngine.Types.NEWCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baseline.Models.NEWCC
{
    public class PolygomyViewModel
    {
        public PolygomyViewModel() {
            Memes = new List<Meme>();
        }
        public string[] MemeCategories { get; set; }
        public List<Meme> Memes { get; set; }
    }
}