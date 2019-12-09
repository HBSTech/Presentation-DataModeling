using Baseline.Models.NEWCC;
using CMS.DocumentEngine.Types.NEWCC;
using CMS.Helpers;
using CMS.Localization;
using CMS.SiteProvider;
using DynamicRouting;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baseline.Controllers.PageTypes
{
    public class ShotgunWeddingController : Controller
    {
        // GET: ShotgunWedding
        public ActionResult Index()
        {

            ShotgunWedding Page = DynamicRouteHelper.GetPage<ShotgunWedding>();
            HttpContext.Kentico().PageBuilder().Initialize(Page.DocumentID);
            ShotgunWeddingViewModel model = new ShotgunWeddingViewModel()
            {
                ConcertTitle = Page.ConcertName
            };

            foreach(Guid NodeGuid in Page.Songs.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => ValidationHelper.GetGuid(x, Guid.Empty)))
            {
                model.Songs.Add(SongProvider.GetSong(NodeGuid, LocalizationContext.CurrentCulture.CultureCode, SiteContext.CurrentSiteName));
            }

            return View("NEWCC/ShotgunWedding", model);
        }
    }
}