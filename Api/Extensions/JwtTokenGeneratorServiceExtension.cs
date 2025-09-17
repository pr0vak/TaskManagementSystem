using TaskManagement.API.Services;

namespace TaskManagement.API.Extensions;

public static class JwtTokenGeneratorServiceExtension
{
    public static IServiceCollection AddJwtTokenGenerator(
        this IServiceCollection services)
    {
        return services.AddScoped<JwtTokenGenerator>();       
    }
}
