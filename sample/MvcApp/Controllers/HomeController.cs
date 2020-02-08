using Analytics.Ecommerce;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Analytics.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            ViewBag.Menu = GetMvcActionMethods();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pageview()
        {
            Analytics.Session session = new Session();
            session.Pageview = new Pageview("/home/pageview", "real-time visitor");
            ViewBag.AnalyticSession = session;
            return View();
        }
        public ActionResult Event()
        {
            Analytics.Session session = new Session();
            session.Events.Add(new Event("button", "click", "submit", "1"));
            ViewBag.AnalyticSession = session;
            return View();
        }
        public ActionResult Ecommerce()
        {
            Analytics.Session session = new Session();
            session.Transaction = new Transaction("1234", "store", 1.0, 1.0);
            session.Transaction.Items.Add(new Item("product a", "a001", "xxx", 2.0, 1));
            session.Transaction.Items.Add(new Item("product b", "b001", "yyy", 3.0, 2));
            ViewBag.AnalyticSession = session;
            return View();
        }
        private IEnumerable<string> GetMvcActionMethods()
        {
            return from action in typeof(HomeController).GetMethods(BindingFlags.Public | BindingFlags.Instance)
                   where action.ReturnType == typeof(ActionResult)
                   select action.Name;
        }
    }
}