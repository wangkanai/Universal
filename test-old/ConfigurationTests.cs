using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wangkanai.Universal.Tests
{
    [TestClass]
    public class ConfigurationTests
    {
        private static Configuration config { get; set; }
        
        public ConfigurationTests()
        {
            config = (Configuration)System.Configuration.ConfigurationManager.GetSection("AnalyticConfigurationSettings/AnalyticConfiguration");
        }

        [TestMethod]
        public void TestConfigAccount()
        {
            Assert.AreEqual("UA-XXXX-Y", config.Account);
        }
        [TestMethod]
        public void TestConfigProperty()
        {
            Assert.AreEqual("sathorn.co.th", config.Property);
        }
    }
}
