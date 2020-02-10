using System;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.Universal.Configuration;
using Xunit;

namespace Wangkanai.Universal.DependencyInjection
{
    public class UniversalCollectionExtensionsTest
    {
        [Fact]
        public void AddGoogleAnalytics_Null_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () => ((IServiceCollection) null).AddGoogleAnalytics("UA-XXXXXX-Y"));
        }

        [Fact]
        public void AddGoogleAnalytics_Options_Null_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () => ((IServiceCollection) null).AddGoogleAnalytics((Action<UniversalOptions>) null));
        }
    }
}