using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.DocumentEngine;

using Kentico.PageBuilder.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Kentico.Web.Mvc;
using KMVCHelper;

namespace Controllers
{

    public class HomeController : PageTemplateController
    {
        // GET: Home
        public ActionResult Index()
        {
            TreeNode page = GetPage();
            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            // Use template if it has one.
            return View();
        }
    }
}