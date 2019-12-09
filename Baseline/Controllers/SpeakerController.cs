using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.NEWCC;
using CMS.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baseline.Controllers
{
    [DynamicRouting.Kentico.MVC.StaticRoutePriority]
    public class SpeakerController : Controller
    {
        // GET: Speaker
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SpeakerListingByRelationship(Guid NodeGuid, int NodeID)
        {
            // Get Relationship ID
            int RelationshipNameID = RelationshipNameInfoProvider.GetRelationshipNameInfo("Speakers").RelationshipNameId;

            var query = DocumentHelper.GetDocuments<Speaker>()
                // Inner join on the relationship
                .Source((QuerySource s) => s.InnerJoin(new QuerySourceTable("CMS_Relationship"), new WhereCondition("NodeID = RightNodeID").WhereEquals("RelationshipNameID", RelationshipNameID).WhereEquals("LeftNodeID", NodeID)))
                // Order by the Relationship Order
                .OrderBy("RelationshipOrder");

            return View("NEWCC/Speakers", query.ToList());    
        }
    }
}