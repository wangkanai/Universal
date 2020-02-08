using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormFramework
{
    public partial class SiteMaster : MasterPage
    {
        public Analytics.Session AnalyticsSession { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}