using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Evently_Modules.Events.Api.Events;

public static class CreateEvent
{
    public static void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("events", () =>
        {

        });
    }
}
