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
            /* Prefix User Route */
            var groupUser = app.MapGroup("user");

            /* Create User */
            groupUser.MapPost("/create", async (AddUserRequest requestAddUser, AppDbContext context) =>
            {
                var newUser = new User(requestAddUser.name, requestAddUser.email, requestAddUser.password, requestAddUser.age);

                var checkUserExists = await context.Users.AnyAsync(u => u.getEmail() == newUser.getEmail());

                if (checkUserExists)
                {
                    return Results.BadRequest("User already exists");
                }

                await context.Users.AddAsync(newUser);
                await context.SaveChangesAsync();

                return Results.Redirect($"/user/checkInfo/{newUser.getId()}");
            });

            /* Check yourself user info */
            groupUser.MapGet("/checkInfo/{id}", async (uint id, AppDbContext context) =>
            {
                var user = await context.Users.FindAsync(id);

                if (user == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(user);
            });

            /* Update User */
            groupUser.MapPut("/update/{id}", async (UpdateUserRequest requestUpdateUser, AppDbContext context) =>
            {
                var user = await context.Users.FindAsync(requestUpdateUser.id);

                if (user == null)
                {
                    return Results.NotFound();
                }

                user.setName(requestUpdateUser.name);
                user.setEmail(requestUpdateUser.email);
                user.setPassword(requestUpdateUser.password);
                user.setAge(requestUpdateUser.age);

                await context.SaveChangesAsync();

                return Results.Ok(user);
            });

            /* Delete User */
            groupUser.MapDelete("/delete/{id}", async (uint id, AppDbContext context) =>
            {
                var user = await context.Users.FindAsync(id);

                if (user == null)
                {
                    return Results.NotFound("User not found");
                }

                context.Users.Remove(user);
                await context.SaveChangesAsync();

                return Results.Ok();
            });
        }

    }
}
