namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Helper functions for configuring Google Universal Analytics services.
    /// </summary>
    public interface IUniversalBuilder
    {
        /// <summary>
        /// Gets the <see cref="IServiceCollection" /> services are attached to.
        /// </summary>
        /// <value>
        /// The <see cref="IServiceCollection" /> services are attached to.
        /// </value>
        IServiceCollection Services { get; }
    }
}