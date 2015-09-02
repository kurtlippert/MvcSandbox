﻿using System.Web.Optimization;

namespace MvcSandbox
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

            // Kendo Bundles
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/kendo/kendo.all.js",
                        "~/Scripts/kendo/kendo.aspnetmvc.js"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                        "~/Content/kendo/kendo.common-bootstrap.css",           // Core Kendo CSS that is bootstrap compatible
                        "~/Content/kendo/kendo.common-bootstrap.overrides.css", // Our overrides for Core Kendo CSS
                        "~/Content/kendo/kendo.bootstrap.css",                  // The Kendo Bootstrap Theme Css
                        "~/Content/kendo/kendo.bootstrap.overrides.css"));      // Our overrides for the Bootstrap Theme Css

            bundles.IgnoreList.Clear();
        }
    }
}