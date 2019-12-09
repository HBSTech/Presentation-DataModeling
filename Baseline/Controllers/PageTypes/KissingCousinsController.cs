using Baseline.Models.NEWCC;
using CMS.DocumentEngine.Types.NEWCC;
using DynamicRouting;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meeg.Kentico.ContentComponents.Cms;

namespace Baseline.Controllers.PageTypes
{
    public class KissingCousinsController : Controller
    {
        // GET: KissingCousins
        public ActionResult Index()
        {
            // Temp
            /*HeroBanners Temp = new HeroBanners();
            Temp.Banners = new List<HeroBanner>();
            Temp.Banners.Add(new HeroBanner()
            {
                Banner = new BannerHero()
                {
                    Name = "Image Banner",
                    AltText = "This is an image",
                    ImageUrl = "https://via.placeholder.com/1200x200.png?text=First+Slide",
                    Url = "http://www.devtrev.com"
                }
            });
            Temp.Banners.Add(new HeroBanner()
            {
                Banner = new CTAHero()
                {
                    Name = "Call to Action Banner",
                    CallToAction = "Click me!",
                    BackgroundImageUrl = "https://via.placeholder.com/1200x200.png?text=Second+Slide",
                    Url = "https://www.babylonbee.com"
                }
            });
            string Serialized = Newtonsoft.Json.JsonConvert.SerializeObject(Temp);
            */

            KissingCousins Page = DynamicRouteHelper.GetPage<KissingCousins>();
            HttpContext.Kentico().PageBuilder().Initialize(Page.DocumentID);
            ViewBag.MetaData = Page.GetPageTypeComponent<Component_MetaData>("MetaData");

            KissingCousinsViewModel model = new KissingCousinsViewModel()
            {
                PageName = Page.MenuName
            };

            // Pass to ViewBag
            /*if(!string.IsNullOrWhiteSpace(Page.MetaData))
            {
                ViewBag.MetaData = JsonConvert.DeserializeObject<MetaDataModel>(Page.MetaData);
            }*/

            if(!string.IsNullOrWhiteSpace(Page.Banners))
            {
                model.Banners = new List<IHeroBanner>();
                dynamic data = System.Web.Helpers.Json.Decode(Page.Banners);
                foreach(dynamic banner in data.Banners)
                {
                    // Based on the type, Serialize it back to string then deserialize it into the proper object class
                    switch(banner.BannerType.ToLower())
                    {
                        case "bannerhero":
                            model.Banners.Add(JsonConvert.DeserializeObject<BannerHero>(JsonConvert.SerializeObject(banner.Banner)));
                            break;
                        case "ctahero":
                            model.Banners.Add(JsonConvert.DeserializeObject<CTAHero>(JsonConvert.SerializeObject(banner.Banner)));
                            break;
                    }
                }
            }


            return View("NEWCC/KissingCousins", model);
        }
    }
}