using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Analytics.Tests
{
    [TestClass]
    public class PageviewTests
    {
        [TestMethod]
        public void TestPageviewToString()
        {
            Pageview pageview = new Pageview("/testing", "testing title");
            Assert.AreEqual("ga('send','pageview',{'Page':'/testing','Title':'testing title'});", pageview.ToString());
        }
        [TestMethod]
        public void TestPageviewProperty()
        {
            var option = new PageviewOption() { Page = "/testing", Title = "test" };
            Assert.AreEqual(2, option.Properties.Length);
        }
        [TestMethod]
        public void TestBooleanParameter()
        {
            PageviewOption pageview = new PageviewOption() { AnonymizeIp = true };
            Assert.AreEqual("{'AnonymizeIp':True}", pageview.ToString());
        }
        [TestMethod]
        public void TestPageviewJsScript()
        {
            var session = new Session();
            session.Pageview = new Pageview("/testing", "testing title");
            var script = Analytic.Instance.Render(session);
            Console.WriteLine(script);
        }
    }
}
