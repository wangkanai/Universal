using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public class UniversalBuilder : IUniversalBuilder
    {
        public IServiceCollection Services { get; }

        public UniversalBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }
    }
}