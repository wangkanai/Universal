using System;
using GoogleAnalytics;

namespace WebFormFramework
{
    public partial class Site_Mobile : System.Web.UI.MasterPage
    {
        public Session AnalyticsSession { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}