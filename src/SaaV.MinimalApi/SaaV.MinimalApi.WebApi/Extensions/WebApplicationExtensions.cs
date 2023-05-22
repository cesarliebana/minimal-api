using SaaV.MinimalApi.Core.Domain;
using SaaV.MinimalApi.WebApi.Endpoints;

namespace SaaV.MinimalApi.WebApi.Extensions
{
    public static class WebApplicationExtensions
    {
        public static void MapDummyEndpoints(this WebApplication app)
        {
            RouteGroupBuilder builder = app.MapGroup("/dummies").WithDisplayName("Dummies").WithOpenApi();
            builder.MapGet("/", DummiesEndpoints.GetAllDummies)
                .WithName("GetAllDummies")
                .WithDescription("Gets all dummies")
                .Produces<GetAllDummiesResponse>()
                .WithOpenApi();

            builder.MapGet("/{id}", DummiesEndpoints.GetDummyById)                
                .WithName("GetDummyById")
                .WithDescription("Gets a dummy with an id")
                .Produces<GetDummyResponse>()
                .WithOpenApi();

            builder.MapPost("/", DummiesEndpoints.CreateDummy)
                .WithName("CreateDummy")
                .WithDescription("Creates a dummy")
                .Produces<GetDummyResponse>()
                .WithOpenApi();

            builder.MapPut("/{id}", DummiesEndpoints.UpdateDummy)
                .WithName("UpdateDummy")
                .WithDescription("Updates a dummy")
                .Produces<GetDummyResponse>()
                .WithOpenApi();

            builder.MapDelete("/{id}", DummiesEndpoints.DeleteDummy)
                .WithName("DeleteDummy")
                .WithDescription("Deletes a dummy")
                .WithOpenApi();
        }
    }
}
