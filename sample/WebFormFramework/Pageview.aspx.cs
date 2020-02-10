using System;
using GoogleAnalytics;


namespace WebFormFramework
{
    public partial class Pageview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var session = new Session();
            session.Pageview = new GoogleAnalytics.Pageview("/home/pageview", "real-time visitor");
            (Master as SiteMaster).AnalyticsSession = session;
        }
    }
}