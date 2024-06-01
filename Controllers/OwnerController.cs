using ImobSystem_API.Data;
using ImobSystem_API.DTOs.Owner;
using ImobSystem_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ImobSystem_API.Controllers
{
    public static class OwnerController
    {
        public static void MapOwnerRoutes(this WebApplication app)
        {
            /* Prefix Owner Route */
            var groupOwner = app.MapGroup("owner");

            /* Create Owner */
            groupOwner.MapPost("/create", async (AddOwnerRequest requestAddOwner, AppDbContext context) =>
            {
                var newOwner = new Owner(requestAddOwner.name, requestAddOwner.email, requestAddOwner.phone, requestAddOwner.cpf);

                var checkOwnerExists = await context.Owners.AnyAsync(u => u.Email == newOwner.Email);

                if (checkOwnerExists)
                {
                    return Results.BadRequest("Owner already exists");
                }

                await context.Owners.AddAsync(newOwner);
                await context.SaveChangesAsync();

                return Results.Ok();
            });

            /* Check yourself user info */
            groupOwner.MapGet("/checkInfo/{id}", async (uint id, AppDbContext context) =>
            {
                var user = await context.Owners.FindAsync(id);

                if (user == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(user);
            });

            /* Update Owner */
            groupOwner.MapPut("/update/{id}", async (uint id, UpdateOwnerRequest requestUpdateOwner, AppDbContext context) =>
            {
                var user = await context.Owners.FindAsync(id);

                if (user == null)
                {
                    return Results.NotFound();
                }

                user.Name = requestUpdateOwner.name;
                user.Email = requestUpdateOwner.email;
                user.Phone = requestUpdateOwner.phone;
                user.Cpf = requestUpdateOwner.cpf;

                await context.SaveChangesAsync();

                return Results.Ok(user);
            });

            /* Delete Owner */
            groupOwner.MapDelete("/delete/{id}", async (uint id, AppDbContext context) =>
            {
                var user = await context.Owners.FindAsync(id);

                if (user == null)
                {
                    return Results.NotFound("Owner not found");
                }

                context.Owners.Remove(user);
                await context.SaveChangesAsync();

                return Results.Ok();
            });

            /* Get Owner List */
            groupOwner.MapGet("/checkOwners/{idUser}", async (uint idUser, AppDbContext context) =>
            {

            });
        }
    }
}
