using System;

namespace Wangkanai.Universal.Tests
{
    public class RequireTests
    {
        [Fact]
        public void TestDisplayFeature()
        {
            var config = (Configuration)System.Configuration.ConfigurationManager.GetSection("AnalyticConfigurationSettings/AnalyticConfiguration");
            var require = new DisplayFeatures(config);
            Assert.AreEqual("ga('require', 'displayfeatures');", require.ToString());
        }
    }
}
