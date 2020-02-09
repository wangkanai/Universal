using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IUniversalBuilder
    {
        IServiceCollection Services { get; }
    }
}