using Baseline.Models.NEWCC;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.NEWCC;
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
    public class ArrangedMarriageController : Controller
    {
        // GET: ArrangedMarriage
        public ActionResult Index()
        {
            ArrangedMarriage Page = DynamicRouteHelper.GetPage<ArrangedMarriage>();
            HttpContext.Kentico().PageBuilder().Initialize(Page.DocumentID);

            ArrangedMarriageViewModel model = new ArrangedMarriageViewModel()
            {
                CarTitle = Page.CarName
            };

            // Get Tires
            model.Tires = DocumentHelper.GetDocuments<CarPart>()
                .Path($"{Page.NodeAliasPath}/Tires", PathTypeEnum.Children)
                .OrderBy("NodeOrder")
                .ToList();
            model.Rims = DocumentHelper.GetDocuments<CarPart>()
                .Path($"{Page.NodeAliasPath}/Rims", PathTypeEnum.Children)
                .OrderBy("NodeOrder")
                .ToList();

            return View("NEWCC/ArrangedMarriage", model);
        }
    }
}