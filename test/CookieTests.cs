using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Analytics.Tests
{
    [TestClass]
    public class CookieTests
    {
        [TestMethod]
        public void TestCookieToJs()
        {
            var config = new Configuration();
            config.CookieDomain = "www.sathai.com";
            config.CookieName = "sathai";
            config.CookieExpires = 20000;
            var option = new ConfigOption(config);
            var create = new Create(config, option);
            Assert.AreEqual(
                "ga('create', 'UA-XXXX-Y', 'auto', {'CookieDomain':'www.sathai.com','CookieName':'sathai','CookieExpires':20000});",
                create.ToString());
        }
        [TestMethod]
        public void TestCookieToString()
        {
            var config = new Configuration();
            config.CookieDomain = "www.sathai.com";
            config.CookieName = "sathai";
            config.CookieExpires = 20000;
            var option = new ConfigOption(config);
            Assert.AreEqual("{'CookieDomain':'www.sathai.com','CookieName':'sathai','CookieExpires':20000}",
                option.ToString());
        }
        [TestMethod]
        public void TestToStringDomainOnly()
        {
            var config = new Configuration();
            config.CookieDomain = "www.sathai.com";
            var option = new ConfigOption(config);
            Assert.AreEqual("{'CookieDomain':'www.sathai.com'}",
                option.ToString());
        }
        [TestMethod]
        public void TestToStringDomainAndExpires()
        {
            var config = new Configuration();
            config.CookieDomain = "www.sathai.com";
            config.CookieExpires = 20000;
            var option = new ConfigOption(config);
            Assert.AreEqual("{'CookieDomain':'www.sathai.com','CookieExpires':20000}",
                option.ToString());
        }
    }
}
