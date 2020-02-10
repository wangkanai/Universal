using System;
using Wangkanai.Universal.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Contains extension method to <see cref="IServiceCollection" /> for configuring client services.
    /// </summary>
    public static class UniversalCollectionExtensions
    {
        /// <summary>
        /// Add Google Analytics Service to the services container.
        /// </summary>
        /// <param name="services">The services available in the application.</param>
        /// <param name="trackingId">UA-XXXXXX-Y</param>
        /// <returns></returns>
        public static IUniversalBuilder AddGoogleAnalytics(this IServiceCollection services, string trackingId)
            => services.AddGoogleAnalytics(options => { options.TrackingId = trackingId; });

        /// <summary>
        /// Add Google Analytics Service to the services container.
        /// </summary>
        /// <param name="services">The services available in the application.</param>
        /// <param name="setAction">An <see cref="Action{UniversalOptions}"/> to configure the provided <see cref="UniversalOptions"/>.</param>
        /// <returns></returns>
        public static IUniversalBuilder AddGoogleAnalytics(this IServiceCollection services, Action<UniversalOptions> setAction)
            => services.Configure(setAction)
                       .AddGoogleAnalytics();

        private static IUniversalBuilder AddGoogleAnalytics(this IServiceCollection services)
            => services.AddUniversalBuilder()
                       .AddRequiredPlatformServices()
                       .AddCoreServices()
                       .AddMarkerService();

        private static IUniversalBuilder AddUniversalBuilder(this IServiceCollection services)
            => new UniversalBuilder(services);
    }
}