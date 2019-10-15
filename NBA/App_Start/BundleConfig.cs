using System.Web;
using System.Web.Optimization;

namespace NBA
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //SBADMIN
            bundles.Add(new ScriptBundle("~/bundles/sbadmin_js").Include(
                        "~/Content/sbadmin/vendor/jquery/jquery.min.js",
                        "~/Content/sbadmin/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/sbadmin/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Content/sbadmin/vendor/chart.js/Chart.min.js",
                        "~/Content/sbadmin/vendor/datatables/jquery.dataTables.js",
                        "~/Content/sbadmin/vendor/datatables/dataTables.bootstrap4.js",
                        "~/Content/sbadmin/js/sb-admin.min.js",
                        "~/Content/sbadmin/js/demo/datatables-demo.js",
                        "~/Content/sbadmin/js/demo/chart-area-demo.js"
                        ));

            //SBADMIN2
            bundles.Add(new ScriptBundle("~/bundles/sbadmin2_js").Include(
                        "~/Content/sbadmin2/vendor/jquery/jquery.min.js",
                        "~/Content/sbadmin2/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/sbadmin2/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Content/sbadmin2/js/sb-admin-2.min.js",
                        "~/Content/sbadmin2/vendor/chart.js/Chart.min.js",
                        "~/Content/sbadmin2/js/demo/chart-area-demo.js",
                        "~/Content/sbadmin2/js/demo/chart-pie-demo.js"
                        ));


            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/sbadmin_css").Include(
                      "~/Content/sbadmin/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/sbadmin/vendor/datatables/dataTables.bootstrap4.css",
                      "~/Content/sbadmin/css/sb-admin.css"));

            bundles.Add(new StyleBundle("~/Content/sbadmin2_css").Include(
                      "~/Content/sbadmin2/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/sbadmin2/https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i",
                      "~/Content/sbadmin2/css/sb-admin-2.min.css"));

        }
    }
}
