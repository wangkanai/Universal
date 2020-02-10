using System;
using GoogleAnalytics;

namespace WebFormFramework
{
    public partial class Event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var session = new Session();
            session.Events.Add(new GoogleAnalytics.Event("button", "click", "submit", "1"));
            (Master as SiteMaster).AnalyticsSession = session;
        }
    }
}