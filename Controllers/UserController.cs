using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ImobSystem_API.Models;
using ImobSystem_API.DTOs.User;
using ImobSystem_API.Data;

namespace ImobSystem_API.Controllers
{
    public static class UserController
    {
        /* Create User */
        public static void MapUserEndpoint(this WebApplication app)
        {
            var groupUser = app.MapGroup("user");

            groupUser.MapPost("/create", async (AddUserRequest requestUser, AppDbContext context) =>
            {
                var newUser = await context.Users.AnyAsync(user => user.getEmail() = requestUser.email);
            }
        }

    }
}
