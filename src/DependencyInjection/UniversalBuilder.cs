using System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Helper functions for configuring Google Universal Analytics services.
    /// </summary>
    public class UniversalBuilder : IUniversalBuilder
    {
        /// <summary>
        /// Creates a new instance of <see cref="IUniversalBuilder" />.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection" /> to attach to.</param>
        public UniversalBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }
        
        /// <summary>
        /// Gets the <see cref="IServiceCollection" /> services are attached to.
        /// </summary>
        /// <value>
        /// The <see cref="IServiceCollection" /> services are attached to.
        /// </value>
        public IServiceCollection Services { get; }
    }
}