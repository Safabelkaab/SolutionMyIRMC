using System.Web;
using System.Web.Optimization;

namespace SolutionMyIRMC.MVC
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
                      "~/Content/site.css"));



            bundles.Add(new ScriptBundle("~/bundles/user/js").Include(
                      "~/ressources/js/jquery.js",
                      "~/ressources/js/jquery.easing.1.3.js", "~/ressources/js/bootstrap.min.js",
                      "~/ressources/js/jquery.fancybox.pack.js",
                      "~/ressources/js/jquery.fancybox-media.js", "~/ressources/js/google-code-prettify/prettify.js",
                      "~/ressources/js/portfolio/jquery.quicksand.js",
                      "~/ressources/js/portfolio/setting.js", "~/ressources/js/jquery.flexslider.js",
                      "~/ressources/js/animate.js",
                      "~/ressources/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/user/css").Include(
                      "~/ressources/css/bootstrap.min.css",
                      "~/ressources/css/fancybox/jquery.fancybox.css", "~/ressources/css/jcarousel.css",
                      "~/ressources/css/flexslider.css", "~/ressources/css/style.css",
                      "~/ressources/skins/default.css"));


            bundles.Add(new ScriptBundle("~/bundles/login/js").Include(
                      "~/LoginResources/vendor/jquery/jquery-3.2.1.min.js",
                      "~/LoginResources/vendor/animsition/js/animsition.min.js",
                      "~/LoginResources/vendor/bootstrap/js/popper.js",
                      "~/LoginResources/vendor/bootstrap/js/bootstrap.min.js",
                      "~/LoginResources/vendor/select2/select2.min.js",
                      "~/LoginResources/vendor/daterangepicker/moment.min.js",
                      "~/LoginResources/vendor/daterangepicker/daterangepicker.js",
                      "~/LoginResources/vendor/countdowntime/countdowntime.js",
                      "~/LoginResources/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/login/css").Include(
                      "~/LoginResources/images/icons/favicon.ico",
                      "~/LoginResources/vendor/bootstrap/css/bootstrap.min.css",
                      "~/LoginResources/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/LoginResources/fonts/Linearicons-Free-v1.0.0/icon-font.min.css",
                      "~/LoginResources/vendor/css-hamburgers/hamburgers.css",
                      "~/LoginResources/vendor/animsition/css/animsition.min.css",
                      "~/LoginResources/vendor/select2/select2.min.css",
                      "~/LoginResources/vendor/daterangepicker/daterangepicker.css",
                      "~/LoginResources/css/util.css",
                      "~/LoginResources/css/main.css"));


            bundles.Add(new ScriptBundle("~/bundles/admin/js").Include(
                     "~/ressourcesAdmin/js/lib/jquery/jquery.min.js",
                     "~/ressourcesAdmin/js/lib/bootstrap/js/popper.min.js",
                     "~/ressourcesAdmin/js/lib/bootstrap/js/bootstrap.min.js",
                     "~/ressourcesAdmin/js/jquery.slimscroll.js",
                     "~/ressourcesAdmin/js/sidebarmenu.js",
                     "~/ressourcesAdmin/js/lib/sticky-kit-master/dist/sticky-kit.min.js",
                     "~/ressourcesAdmin/js/lib/morris-chart/raphael-min.js",
                     "~/ressourcesAdmin/js/lib/morris-chart/morris.js",
                     "~/ressourcesAdmin/js/lib/morris-chart/dashboard1-init.js",
                     "~/ressourcesAdmin/js/lib/calendar-2/moment.latest.min.js",
                     "~/ressourcesAdmin/js/lib/calendar-2/semantic.ui.min.js",
                     "~/ressourcesAdmin/js/lib/calendar-2/prism.min.js",
                     "~/ressourcesAdmin/js/lib/calendar-2/pignose.calendar.min.js",
                     "~/ressourcesAdmin/js/lib/calendar-2/pignose.init.js",
                     "~/ressourcesAdmin/js/lib/owl-carousel/owl.carousel.min.js",
                     "~/ressourcesAdmin/js/lib/owl-carousel/owl.carousel-init.js",
                     "~/ressourcesAdmin/js/scripts.js",
                     "~/ressourcesAdmin/js/custom.min.js"
                     ));

            bundles.Add(new StyleBundle("~/Content/admin/css").Include(
                      "~/ressourcesAdmin/images/favicon.png",
                      "~/ressourcesAdmin/css/lib/bootstrap/bootstrap.min.css",
                      "~/ressourcesAdmin/css/lib/calendar2/semantic.ui.min.css",
                      "~/ressourcesAdmin/css/lib/calendar2/pignose.calendar.min.css",
                      "~/ressourcesAdmin/css/lib/owl.carousel.min.css",
                      "~/ressourcesAdmin/css/lib/owl.theme.default.min.css",
                      "~/ressourcesAdmin/css/helper.css",
                      "~/ressourcesAdmin/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/kendo.all.min.js",
                // "~/Scripts/kendo/kendo.timezones.min.js", // uncomment if using the Scheduler
                "~/Scripts/kendo/kendo.aspnetmvc.min.js"));
            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                "~/Content/kendo/kendo.common-bootstrap.min.css",
                "~/Content/kendo/kendo.bootstrap.min.css"));
            bundles.IgnoreList.Clear();
        }
    }
}
