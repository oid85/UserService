using Microsoft.Extensions.DependencyInjection;
using UserService.DataAccess;
using UserService.Application;
using UserService.Application.Services;
using UserService.DataAccess.Db;
using Microsoft.EntityFrameworkCore;

namespace UserService.App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Добавим поддержку внедрения зависимостей
            IServiceCollection services = new ServiceCollection();

            services.AddApplicationDbContext();
            services.AddApplicationServices();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            
            // Выполним миграции
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            await context.Database.MigrateAsync();

            // Демонстрация работы
            var userDataService = serviceProvider.GetService<UserDataService>();

            // Вызов методов сервиса UserDataService
            var userByIdAndDomain = await userDataService!.GetUserByIdAndDomainAsync(Guid.Parse("d8d51a5e-1350-4bb0-b96b-190406924a68"), "example1.com"); // Name = "name1"
            var usersByDomain = await userDataService.GetUsersByDomainAsync("example1.com", 1, 2); // Count = 2
            var usersByTagAndDomain = await userDataService.GetUsersByTagAndDomainAsync("value1", "example1.com"); // Count = 3
        }
    }
}
