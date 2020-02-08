using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wangkanai.Universal.Tests
{
    [TestClass]
    public class EnhancedTests
    {
        [TestMethod]
        public void TestEnhancedWithCookie()
        {
            var config = new Configuration();
            config.EnhancedLink = true;
            config.EnhancedCookieName = "_ela";
            config.EnhancedDuration = 45;
            config.EnhancedLevels = 5;
            var enhanced = new EnhancedLink(config);
            Assert.AreEqual("ga('require', 'linkid', 'linkid.js', {'CookieName':'_ela','Duration':45,'Levels':5});", enhanced.ToString());
        }

        [TestMethod]
        public void TestEnhancedWithoutCookie()
        {
            var config = new Configuration();
            var enhanced = new EnhancedLink(config);
            Assert.AreEqual("ga('require', 'linkid', 'linkid.js');", enhanced.ToString());
        }
    }
}
