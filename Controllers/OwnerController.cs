using ImobSystem_API.Data;
using ImobSystem_API.DTOs.Owner;
using ImobSystem_API.Models;

namespace ImobSystem_API.Controllers
{
    public static class OwnerController
    {
        public static void MapOwnerEndpoint(this WebApplication app)
        {
            /* Prefix Owner Route */
            var groupOwner = app.MapGroup("user");

            /* Create Owner */
            groupOwner.MapPost("/create", async (AddOwnerRequest requestAddOwner, AppDbContext context) =>
            {
                var newOwner = new Owner(requestAddOwner.name, requestAddOwner.email, requestAddOwner.phone, requestAddOwner.CPF);

                var checkOwnerExists = await context.Owners.AnyAsync(u => u.getEmail() == newOwner.getEmail());

                if (checkOwnerExists)
                {
                    return Results.BadRequest("Owner already exists");
                }

                await context.Owners.AddAsync(newOwner);
                await context.SaveChangesAsync();

                return Results.Redirect($"/user/checkInfo/{newOwner.getId()}");
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
            groupOwner.MapPut("/update/{id}", async (UpdateOwnerRequest requestUpdateOwner, AppDbContext context) =>
            {
                var user = await context.Owners.FindAsync(requestUpdateOwner.id);

                if (user == null)
                {
                    return Results.NotFound();
                }

                user.setName(requestUpdateOwner.name);
                user.setEmail(requestUpdateOwner.email);
                user.setPassword(requestUpdateOwner.password);
                user.setAge(requestUpdateOwner.age);

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
        }
    }
}
