using System.Web;
using System.Web.Optimization;

namespace WebMVCApplication.WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Assets

            bundles.Add(new StyleBundle("~/styles/assets").Include(
               "~/Assets/css/style.css"
           ));

            bundles.Add(new StyleBundle("~/scripts/assets").Include(
                "~/Assets/js/vue.js",
                "~/Assets/js/main.js"
            ));

            #endregion

            #region Main

            bundles.Add(new StyleBundle("~/styles/main").Include(
               "~/Vendors/bootstrap/dist/css/bootstrap.min.css",
               "~/Vendors/font-awesome/css/font-awesome.min.css",
               "~/Vendors/themify-icons/css/themify-icons.css",
               "~/Vendors/flag-icon-css/css/flag-icon.min.css",
               "~/Vendors/selectFX/css/cs-skin-elastic.css"
           ));

            bundles.Add(new ScriptBundle("~/scripts/main").Include(
                "~/Vendors/jquery/dist/jquery.min.js",
                "~/Vendors/popper.js/dist/umd/popper.min.js",
                "~/Vendors/bootstrap/dist/js/bootstrap.min.js"
            ));

            #endregion

            #region Dashboard 

            bundles.Add(new ScriptBundle("~/styles/dashboard").Include(
                "~/Vendors/jqvmap/dist/jqvmap.min.css"
            ));

            bundles.Add(new ScriptBundle("~/scripts/dashboard").Include(
                "~/Vendors/chart.js/dist/Chart.bundle.min.js",
                "~/Assets/js/dashboard.js",
                "~/Assets/js/widgets.js",
                "~/Vendors/jqvmap/dist/jquery.vmap.min.js",
                "~/Vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                "~/Vendors/jqvmap/dist/maps/jquery.vmap.world.js"
            ));

            #endregion
        }
    }
}