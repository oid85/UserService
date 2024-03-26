using Microsoft.Extensions.DependencyInjection;
using UserService.Application.Services;

namespace UserService.Application;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<UserDataService>();
    }
}