using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore;
using ImobSystem_API.Controllers;
using NuGet.DependencyResolver;

namespace ImobSystem_API.Routes
{
    public static class UserEndpoints
    {
        public UserEndpoints(WebApplication app)
        {
            var prefixRoutesUser = app.MapGroup("user");

            prefixRoutesUser.MapPost("/create", )
        }

        public static RouteGroupBuilder MapUserEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("user").WithParameterValidation();

            return group;
        }

    }
}
