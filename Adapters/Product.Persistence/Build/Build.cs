using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Persistence.Context;

public static class Build
{
    public static void AddContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connection = configuration.GetConnectionString("Default") ?? string.Empty;

        services.AddDbContext<AppDbContext>(options => options.UseSqlite(connection));
    }
}