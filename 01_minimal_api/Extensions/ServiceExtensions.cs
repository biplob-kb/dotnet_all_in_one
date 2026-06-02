using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_minimal_api.DbContexts;
using _01_minimal_api.Repositories.Implementations;
using _01_minimal_api.Repositories.Interfaces;
using _01_minimal_api.Services.Implementations;
using _01_minimal_api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _01_minimal_api.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddServiceExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AuthDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped<IUserRepo, UserRepo>();

        services.AddScoped<IUserServices, UserServices>();
        return services;
    }
}
