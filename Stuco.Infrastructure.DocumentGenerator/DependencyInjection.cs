namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddDocumentGenerator(this IServiceCollection services)
    {
        services.AddXceedInfrastructure();
        return services;
    }
}