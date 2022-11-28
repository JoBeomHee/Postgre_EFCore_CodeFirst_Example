using EFCore_CodeFirst_Example.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCore_CodeFirst_Example.Extension;

public static class DatabaseExtension
{
    public static IServiceCollection AddPostgreSQLDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddTransient<ISchoolDbContext, SchoolDbContext>();
        services.AddDbContextFactory<SchoolDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("PostgreDb"),
                    b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name))
                .EnableSensitiveDataLogging();
        });

        return services;
    }
}
