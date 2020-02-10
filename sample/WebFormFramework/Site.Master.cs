using System;
using System.Web.UI;
using GoogleAnalytics;


namespace WebFormFramework
{
    public partial class SiteMaster : MasterPage
    {
        public Session AnalyticsSession { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}