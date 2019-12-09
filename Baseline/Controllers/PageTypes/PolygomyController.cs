using CMS.DocumentEngine.Types.NEWCC;
using DynamicRouting;
using Kentico.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Web.Mvc;
using CMS;
using System.Linq;
using CMS.DocumentEngine;
using System.Collections.Generic;
using Baseline.Models.NEWCC;
using CMS.Taxonomy;
using CMS.Helpers;
using RelationshipsExtended;

namespace Baseline.Controllers.PageTypes
{
    public class PolygomyController : Controller
    {
        // GET: Polygomy
        public ActionResult Index()
        {
            Polygomy Page = DynamicRouteHelper.GetPage<Polygomy>();
            HttpContext.Kentico().PageBuilder().Initialize(Page.DocumentID);
            // Get Categories
            List<int> PageCategories = TreeCategoryInfoProvider.GetTreeCategories()
                .WhereEquals("NodeID", Page.NodeID)
                .Select(x => x.CategoryID).ToList();

            PolygomyViewModel model = new PolygomyViewModel()
            {
                MemeCategories = CategoryInfoProvider.GetCategories()
                .WhereIn("CategoryID", PageCategories)
                .Select(x => x.CategoryDisplayName).ToArray(),
            };
            if(PageCategories.Count > 0)
            {
                model.Memes = MemeProvider.GetMemes()
                .Where(RelHelper.GetNodeCategoryWhere(PageCategories.Select(x => (object)x)))
                .ToList();
            }
            return View("NEWCC/Polygomy", model);
        }
    }
}