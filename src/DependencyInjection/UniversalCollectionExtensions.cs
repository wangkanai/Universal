using System;
using Wangkanai.Universal.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class UniversalCollectionExtensions
    {
        public static IUniversalBuilder AddGoogleAnalytics(this IServiceCollection services, Action<UniversalOptions> setAction)
            => services.Configure(setAction)
                       .AddUniversalBuilder();

        public static IUniversalBuilder AddGoogleAnalytics(this IServiceCollection services)
            => services.AddUniversalBuilder();
        
        private static IUniversalBuilder AddUniversalBuilder(this IServiceCollection services)
            => new UniversalBuilder(services);
    }
}