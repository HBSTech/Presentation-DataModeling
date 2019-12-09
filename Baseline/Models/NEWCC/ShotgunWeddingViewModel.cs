using CMS.DocumentEngine.Types.NEWCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baseline.Models.NEWCC
{
    public class ShotgunWeddingViewModel
    {
        public ShotgunWeddingViewModel() {
            Songs = new List<Song>();
        }

        public string ConcertTitle { get; set; }
        public List<Song> Songs { get; set; }
    }
}