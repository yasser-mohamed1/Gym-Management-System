namespace GymManagement.Application;
using GymManagement.Application.Services;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ISubscriptionService, SubscriptionService>();
        return services;
    }
}