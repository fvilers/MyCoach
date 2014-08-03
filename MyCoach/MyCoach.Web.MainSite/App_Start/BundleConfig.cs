using System.Web.Optimization;

namespace MyCoach.Web.MainSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/site.js")
                .Include("~/Scripts/underscore.js"));


            bundles.Add(new ScriptBundle("~/bundles/home")
                .Include("~/Scripts/typeahead.jquery.js")
                .Include("~/Scripts/handlebars.js")
                .Include("~/Scripts/moment.js")
                .Include("~/Scripts/home.js")
            );

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap")
            //    .Include("~/Scripts/bootstrap.js")
            //    .Include("~/Scripts/respond.js")
            //);

            //bundles.Add(new StyleBundle("~/Content/css")
            //    .Include("~/Content/bootstrap.css")
            //    .Include("~/Content/site.css")
            //);
        }
    }
}