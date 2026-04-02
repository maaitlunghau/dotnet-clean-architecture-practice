using CLEAN_APPLICATION.Interfaces.Services;
using CLEAN_APPLICATION.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CLEAN_APPLICATION;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
