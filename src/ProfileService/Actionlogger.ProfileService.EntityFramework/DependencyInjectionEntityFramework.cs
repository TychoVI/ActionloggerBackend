using Actionlogger.Core.Entity;
using Actionlogger.ProfileService.Core.Interface;
using Actionlogger.ProfileService.EntityFramework.Data;
using Actionlogger.ProfileService.EntityFramework.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Actionlogger.ProfileService.EntityFramework;

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
        
        services.AddTransient<IProfileRepository, ProfileRepository>();

        return services;
    }
}