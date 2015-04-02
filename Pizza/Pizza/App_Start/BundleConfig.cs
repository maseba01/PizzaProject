using System.Web.Optimization;

namespace Pizza.Web.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/commoncss")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/Site.css")
                .Include("~/Content/Home.css")                
                );


            bundles.Add(new ScriptBundle("~/bundles/commonjavascript")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/jquery-2.1.3.js")
                );

            BundleTable.EnableOptimizations = true;

        }
    }
}