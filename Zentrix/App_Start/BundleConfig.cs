using System.Web;
using System.Web.Optimization;

namespace Zentrix
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/bower_components/font-awesome/css/font-awesome.min.css",
                      //"~/bower_components/Ionicons/css/ionicons.min.css",
                      "~/dist/css/AdminLTE.css",
                      "~/dist/css/skins/_all-skins.min.css"));

            //bundles.Add(new StyleBundle("~/Content/DatepickerCss").Include(
            //         "~/Content/bootstrap-datepicker.css"));
            bundles.Add(new ScriptBundle("~/bundles/DataPikerCss").Include(
"~/Content/bootstrap-datepicker.css").IncludeDirectory("~/Content", ".css"));

            bundles.Add(new ScriptBundle("~/bundles/DataPikerJs").Include(
                "~/Scripts/bootstrap-datepicker.js").IncludeDirectory("~/Scripts", ".js"));

            //<link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.min.css">

        }
    }
}
