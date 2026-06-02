using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_minimal_api.Endpoints;

namespace _01_minimal_api.Extensions;

public static class EndpointExtensions
{
    public static WebApplication MapEndpointExtensions(this WebApplication app)
    {
        app.MapUserEndpoints();
        return app;
    }

}
