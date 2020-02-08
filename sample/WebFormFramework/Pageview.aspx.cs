using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormFramework
{
    public partial class Pageview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Analytics.Session session = new Session();
            session.Pageview = new Analytics.Pageview("/home/pageview", "real-time visitor");
            (Master as SiteMaster).AnalyticsSession = session;
        }
    }
}