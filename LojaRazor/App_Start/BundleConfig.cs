using System.Web;
using System.Web.Optimization;

namespace LojaRazor
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle estilos = new StyleBundle("~/bundles/estilos");
            estilos.Include("~/Content/bootstrap/css/bootstrap.css");
            estilos.Include("~/Content/Style.css");
            bundles.Add(estilos);

            ScriptBundle script = new ScriptBundle("~/bundles/scripts");
            script.Include("~/Scripts/jquery-1.7.1.js");
            script.Include("~/Scripts/jquery.validate.js");
            script.Include("~/Scripts/jquery.validate.unobtrusive.js");
            bundles.Add(script);
        }
    }
}