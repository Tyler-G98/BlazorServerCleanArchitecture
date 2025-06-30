using Microsoft.Extensions.DependencyInjection;

namespace BlazorServerCleanArchitecture.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

        // Add AutoMapper, Validators, etc. as needed
        return services;
    }
}

