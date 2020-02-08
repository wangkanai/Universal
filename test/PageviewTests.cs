using System;

namespace Wangkanai.Universal.Tests
{
    public class PageviewTests
    {
        [Fact]
        public void TestPageviewToString()
        {
            Pageview pageview = new Pageview("/testing", "testing title");
            Assert.AreEqual("ga('send','pageview',{'Page':'/testing','Title':'testing title'});", pageview.ToString());
        }
        [Fact]
        public void TestPageviewProperty()
        {
            var option = new PageviewOption() { Page = "/testing", Title = "test" };
            Assert.AreEqual(2, option.Properties.Length);
        }
        [Fact]
        public void TestBooleanParameter()
        {
            PageviewOption pageview = new PageviewOption() { AnonymizeIp = true };
            Assert.AreEqual("{'AnonymizeIp':True}", pageview.ToString());
        }
        [Fact]
        public void TestPageviewJsScript()
        {
            var session = new Session();
            session.Pageview = new Pageview("/testing", "testing title");
            var script = Analytic.Instance.Render(session);
            Console.WriteLine(script);
        }
    }
}
