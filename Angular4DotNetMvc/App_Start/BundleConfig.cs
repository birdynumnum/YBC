using System.Web;
using System.Web.Optimization;

namespace Angular4DotNetMvc.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Cards").Include(
                      "~/Scripts/Cards/cards-controller.js",
                      "~/Scripts/Cards/addCard-controller.js",
                      "~/Scripts/Cards/editCard-controller.js",
                      "~/Scripts/Cards/deleteCard-controller.js",
                      "~/Scripts/Cards/searchCard-controller.js",

                      "~/Scripts/Cards/Services/cardRepository.js",
                      "~/Scripts/Cards/Services/cardIdService.js",
                      "~/Scripts/Cards/Services/notificationService.js",

                      "~/Scripts/Cards/Layout/topbar.js",
                      "~/Scripts/Cards/Layout/sidebar.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css",
                      "~/Content/bootstrap/bootstrap.min.css",
                      "~/Content/bootstrap/bootstrap-cerulean.css",
                      "~/Content/bootstrap/app.css",
                      "~/Content/toastr.css"));
        }
    }
}

