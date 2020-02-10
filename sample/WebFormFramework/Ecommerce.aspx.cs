using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoogleAnalytics;
using GoogleAnalytics.Ecommerce;

namespace WebFormFramework
{
    public partial class Ecommerce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var session = new Session();
            session.Transaction = new Transaction("1234", "store", 1.0, 1.0);
            session.Transaction.Items.Add(new Item("product a", "a001", "xxx", 2.0, 1));
            session.Transaction.Items.Add(new Item("product b", "b001", "yyy", 3.0, 2));
            (Master as SiteMaster).AnalyticsSession = session;
        }
    }
}