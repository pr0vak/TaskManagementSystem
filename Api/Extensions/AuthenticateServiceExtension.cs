using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace TaskManagement.API.Extensions;

public static class AuthenticateServiceExtension
{
    public static IServiceCollection AddAuthenticationConfig(
        this IServiceCollection services, IConfiguration configuration)
    {
        var secretKey = configuration["AuthSettings:Secret"];

        services.AddAuthentication(opt =>
        {
            opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(opt =>
        {
            opt.RequireHttpsMetadata = false;
            opt.SaveToken = true;
            opt.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(secretKey)),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });

        return services;       
    }
}
