using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Wangkanai.Universal.Configuration;
using Wangkanai.Universal.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class UniversalCoreBuilderExtensions
    {
        public static IUniversalBuilder AddRequiredPlatformServices(this IUniversalBuilder builder)
        {
            // Hosting doesn't add IHttpContextAccessor by default
            builder.Services.AddHttpContextAccessor();

            // Add Detection Options
            builder.Services.AddOptions();
            builder.Services.TryAddSingleton(
                provider => provider.GetRequiredService<IOptions<UniversalOptions>>().Value);

            return builder;
        }

        public static IUniversalBuilder AddCoreServices(this IUniversalBuilder builder)
        {
            // Add Basic core to services
            
            
            return builder;
        }

        public static IUniversalBuilder AddMarkerService(this IUniversalBuilder builder)
        {
            builder.Services.TryAddSingleton<UniversalMarkerService, UniversalMarkerService>();
            
            return builder;
        }
    }
}