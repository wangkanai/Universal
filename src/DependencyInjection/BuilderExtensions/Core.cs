using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Wangkanai.Universal.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class UniversalCoreBuilderExtensions
    {
        public static IUniversalBuilder AddRequiredPlatformServices(this IUniversalBuilder builder)
        {
            return builder;
        }

        public static IUniversalBuilder AddCoreServices(this IUniversalBuilder builder)
        {
            return builder;
        }

        public static IUniversalBuilder AddMarkerService(this IUniversalBuilder builder)
        {
            builder.Services.TryAddSingleton<UniversalMarkerService, UniversalMarkerService>();
            
            return builder;
        }
    }
}