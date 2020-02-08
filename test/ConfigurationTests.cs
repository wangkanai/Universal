using System;
using System.Configuration;

namespace Wangkanai.Universal.Tests
{
    public class ConfigurationTests
    {
        private static Configuration config { get; set; }
        
        public ConfigurationTests()
        {
            config = (Configuration)System.Configuration.ConfigurationManager.GetSection("AnalyticConfigurationSettings/AnalyticConfiguration");
        }

        [Fact]
        public void TestConfigAccount()
        {
            Assert.AreEqual("UA-XXXX-Y", config.Account);
        }
        [Fact]
        public void TestConfigProperty()
        {
            Assert.AreEqual("sathorn.co.th", config.Property);
        }
    }
}
