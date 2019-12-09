using Baseline.Models.Master;
using CMS.DocumentEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baseline.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MainNav()
        {
            // get all the first level pages
            MainNavViewModel model = new MainNavViewModel
            {
                NavItems = DocumentHelper.GetDocuments()
                .WhereEquals("NodeLevel", 1)
                .OrderBy("NodeOrder")
                .WhereNotEquals("ClassName", "CMS.Folder")
                .Select(x => new MainNavItem()
                {
                    Text = x.DocumentName,
                    Url = x.RelativeURL
                })
            };

            return View(model);
        }
    }
}