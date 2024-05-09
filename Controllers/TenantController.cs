using ImobSystem_API.Data;
using ImobSystem_API.DTOs.Tenant;
using ImobSystem_API.Models;

namespace ImobSystem_API.Controllers
{
    public static class TenantController
    {
        public static void MapTenantEndpoint(this WebApplication app)
        {
            /* Prefix Tenant Route */
            var groupTenant = app.MapGroup("user");

            /* Create Tenant */
            groupTenant.MapPost("/create", async (AddTenantRequest requestAddTenant, AppDbContext context) =>
            {
                var newTenant = new Tenant(requestAddTenant.name, requestAddTenant.email, requestAddTenant.phone, requestAddTenant.CPF);

                var checkTenantExists = await context.Tenants.AnyAsync(u => u.getEmail() == newTenant.getEmail());

                if (checkTenantExists)
                {
                    return Results.BadRequest("Tenant already exists");
                }

                await context.Tenants.AddAsync(newTenant);
                await context.SaveChangesAsync();

                return Results.Redirect($"/user/checkInfo/{newTenant.getId()}");
            });

            /* Check yourself user info */
            groupTenant.MapGet("/checkInfo/{id}", async (uint id, AppDbContext context) =>
            {
                var user = await context.Tenants.FindAsync(id);

                if (user == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(user);
            });

            /* Update Tenant */
            groupTenant.MapPut("/update/{id}", async (UpdateTenantRequest requestUpdateTenant, AppDbContext context) =>
            {
                var user = await context.Tenants.FindAsync(requestUpdateTenant.id);

                if (user == null)
                {
                    return Results.NotFound();
                }

                user.setName(requestUpdateTenant.name);
                user.setEmail(requestUpdateTenant.email);
                user.setPassword(requestUpdateTenant.password);
                user.setAge(requestUpdateTenant.age);

                await context.SaveChangesAsync();

                return Results.Ok(user);
            });

            /* Delete Tenant */
            groupTenant.MapDelete("/delete/{id}", async (uint id, AppDbContext context) =>
            {
                var user = await context.Tenants.FindAsync(id);

                if (user == null)
                {
                    return Results.NotFound("Tenant not found");
                }

                context.Tenants.Remove(user);
                await context.SaveChangesAsync();

                return Results.Ok();
            });
        }
    }
}
