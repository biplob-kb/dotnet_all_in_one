using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_minimal_api.Services.Interfaces;

namespace _01_minimal_api.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        app.MapGet("/users", async (IUserServices userServices) =>
        {
            var users = await userServices.GetAllUsers();
            return Results.Ok(users);
        });
    }
}
