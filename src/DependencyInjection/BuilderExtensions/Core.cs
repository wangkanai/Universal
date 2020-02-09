namespace Microsoft.Extensions.DependencyInjection.BuilderExtensions
{
    public static class UniversalCoreBuilderExtensions
    {
        public static IUniversalBuilder AddRequiredPlatformServices(this IUniversalBuilder builder)
        {
            return builder;
        }
    }
}