using System.Web;
using System.Web.Optimization;

namespace MetroAppSite
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Light Metro UI theme
            bundles.Add(new StyleBundle("~/Content/metro-light/css").Include("~/Content/css/metro-ui-light.css", "~/Content/site.css"));

            //Dark Metro UI theme
            bundles.Add(new StyleBundle("~/Content/metro-dark/css").Include("~/Content/css/metro-ui-dark.css", "~/Content/site.css"));

            //Base Metro UI theme
            bundles.Add(new StyleBundle("~/Content/base/css").Include("~/Content/css/bootstrap.css",
                "~/Content/css/bootstrap-responsive.css",
                "~/Content/css/bootmetro.css",
                "~/Content/css/bootmetro-tiles.css",
                "~/Content/css/bootmetro-charms.css",
                "~/Content/css/datepicker.css",
                "~/Content/css/icomoon.css"));
        }
    }
}