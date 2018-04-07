using System.Web.Optimization;

namespace www
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection Bundles)
        {
            bundles.Add(new StyleBundle("~/Styles").Include(
                      "~/Content/custom.css"));
        }
    }
}
