using System.Web;
using System.Web.Optimization;

namespace ASP.NET_MVC_App
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Script/javascript").Include(
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-route.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/products.css",
                      "~/Content/site.css"));
        }
    }
}
