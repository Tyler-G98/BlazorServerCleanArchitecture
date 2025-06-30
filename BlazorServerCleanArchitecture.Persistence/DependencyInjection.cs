using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BlazorServerCleanArchitecture.Application;
using BlazorServerCleanArchitecture.Infrastructure;

namespace BlazorServerCleanArchitecture.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<ApplicationDbContext>(provider =>
            provider.GetRequiredService<ApplicationDbContext>());

        // Add repository registrations here if needed

        return services;
    }
}

