using Actionlogger.ActionService.Core.Interface;
using Actionlogger.ActionService.EntityFramework.Data;
using Actionlogger.ActionService.EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Actionlogger.ActionService.EntityFramework;

public static class DependencyInjectionEntityFramework
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(x =>
        {
            x.UseMySql(
                    connectionString,ServerVersion.AutoDetect(connectionString))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        });
        
        services.AddTransient<IActionRepository, ActionRepository>();

        return services;
    }
}