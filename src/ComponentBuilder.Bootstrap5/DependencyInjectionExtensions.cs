using Microsoft.Extensions.DependencyInjection;

namespace ComponentBuilder.Bootstrap5;
public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddBootstrap5(this IServiceCollection services)
    {
        return services.AddComponentBuilder();
    }
}
