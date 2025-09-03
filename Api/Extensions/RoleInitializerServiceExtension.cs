using Microsoft.AspNetCore.Identity;
using TaskManagement.API.SharedData;

namespace TaskManagement.API.Extensions;

public static class RoleInitializerServiceExtension
{
    public static async Task InitializeRolesAsync(
        this IServiceProvider service)
    {
        await using var scope = service.CreateAsyncScope();
        var roleManager = scope.ServiceProvider
            .GetRequiredService<RoleManager<IdentityRole>>();

        foreach (var role in Roles.GetRoles())
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }
    }
}
