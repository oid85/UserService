using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserService.DataAccess.Db;

namespace UserService.DataAccess;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationDbContext(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlite("Data Source=database.db");
        }, ServiceLifetime.Scoped, ServiceLifetime.Scoped);
    }
}