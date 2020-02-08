using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Analytics.Tests
{
    [TestClass]
    public class RequireTests
    {
        [TestMethod]
        public void TestDisplayFeature()
        {
            var config = (Configuration)System.Configuration.ConfigurationManager.GetSection("AnalyticConfigurationSettings/AnalyticConfiguration");
            var require = new DisplayFeatures(config);
            Assert.AreEqual("ga('require', 'displayfeatures');", require.ToString());
        }
    }
}
