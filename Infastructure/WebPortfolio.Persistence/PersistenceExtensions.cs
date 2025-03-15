using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebPortfolio.Domain.Entities;
using WebPortfolio.Persistence.Context;
using WebPortfolio.Persistence.Seed;

namespace WebPortfolio.Persistence;

public static class PersistenceExtensions
{
    public static void AddPersistenceLayer(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }

    public static async Task UseIdentityDatabaseSeederAsync(this IServiceProvider service)
    {
        using (var scope = service.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();

            await IdentitySeeder.SeedAsync(userManager, roleManager);
        }
    }

}
