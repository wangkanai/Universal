using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormFramework
{
    public partial class Event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Analytics.Session session = new Session();
            session.Events.Add(new Analytics.Event("button", "click", "submit", "1"));
            (Master as SiteMaster).AnalyticsSession = session;
        }
    }
}