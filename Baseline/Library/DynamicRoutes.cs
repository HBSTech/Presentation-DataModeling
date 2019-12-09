using Baseline.Controllers.PageTypes;
using CMS.DocumentEngine.Types.NEWCC;
using DynamicRouting.Kentico.MVC;

[assembly: DynamicRouting("NEWCC/Inbreeding", typeof(Inbreeding), Inbreeding.CLASS_NAME)]
[assembly: DynamicRouting(typeof(KissingCousinsController), new string[] { KissingCousins.CLASS_NAME })]
[assembly: DynamicRouting(typeof(ShotgunWeddingController), new string[] { ShotgunWedding.CLASS_NAME })]
[assembly: DynamicRouting(typeof(ArrangedMarriageController), new string[] { ArrangedMarriage.CLASS_NAME })]
[assembly: DynamicRouting(typeof(PolygomyController), new string[] { Polygomy.CLASS_NAME })]
[assembly: DynamicRouting("NEWCC/HolyMatrimony", typeof(HolyMatrimony), HolyMatrimony.CLASS_NAME)]