using Appointments.Api.Infrastructure.Endpoints;
using Appointments.Api.Infrastructure.Logging;
using Appointments.Api.Infrastructure.RateLimiting;
using Asp.Versioning;

namespace Appointments.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddApiVersion();
        services.AddEndpoints();
        services.AddOpenApi();
        services.AddProblemDetails();

        services.AddCustomRateLimiting(builder.Configuration);
        services.AddCustomHttpLogging(builder.Environment);
        services.AddOutputCaching();

        return services;
    }

    private static IServiceCollection AddApiVersion(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new(1);
            options.ReportApiVersions = true;
            options.ApiVersionReader = new UrlSegmentApiVersionReader();
        })
        .AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'V";
            options.SubstituteApiVersionInUrl = true;
        });

        return services;
    }

    private static IServiceCollection AddOutputCaching(this IServiceCollection services)
    {
        services.AddOutputCache(options =>
        {
            options.DefaultExpirationTimeSpan = TimeSpan.FromSeconds(60);
            options.MaximumBodySize = 1024 * 1024; // 1 MB
        });

        return services;
    }
}