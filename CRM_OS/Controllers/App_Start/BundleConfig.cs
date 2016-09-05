using System.Web;
using System.Web.Optimization;

namespace CRM_OS
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 
                      "~/bootstrap/js/bootstrap.min.js",
                      "~/plugins/fastclick/fastclick.js",
                      "~/plugins/jQuery/jquery-2.2.3.min.js",
                      "~/plugins/sparkline/jquery.sparkline.min.js",
                      "~/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                      "~/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                      "~/plugins/slimScroll/jquery.slimscroll.min.js",
                      "~/plugins/chartjs/Chart.min.js",
                      "~/dist/js/demo.js",
                      "~/dist/js/app.min.js",
                      "~/dist/js/pages/dashboard2.js")
                      );
            
            bundles.Add(new StyleBundle("~/dist/admin").Include(                    
                     "~/dist/css/skins/skin-green-light.css",
                     "~/dist/css/AdminLTE.css",
                     "~/fonts/ionicons.min.css",
                     "~/fonts/font-awesome.min.css",
                     "~/bootstrap/css/bootstrap.min.css",
                     "~/plugins/jvectormap/jquery-jvectormap-1.2.2.css")
                     );

           
        }
    }
}
