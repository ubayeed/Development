using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Datatables.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/Scripts/site").Include(
                "~/Scripts/DataTables/jquery.dataTables.js"
                ));
            bundles.Add(new StyleBundle("~/Content/styles").Include(
                "~/Content/DataTables/css/jquery.dataTables.css"
                ));
        }
    }
}