using ImobSystem_API.Data;
using ImobSystem_API.DTOs.Tenant;
using ImobSystem_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ImobSystem_API.Controllers
{
    public static class TenantController
    {
        public static void MapTenantRoutes(this WebApplication app)
        {
            /* Prefix Tenant Route */
            var groupTenant = app.MapGroup("tenant");

            /* Create Tenant */
            groupTenant.MapPost("/create", async (AddTenantRequest requestAddTenant, AppDbContext context) =>
            {
                var newTenant = new Tenant(requestAddTenant.name, requestAddTenant.email, requestAddTenant.phone, requestAddTenant.cpf);

                var checkTenantExists = await context.Tenants.AnyAsync(t => t.getEmail() == newTenant.getEmail());

                if (checkTenantExists)
                {
                    return Results.BadRequest("Tenant already exists");
                }

                await context.Tenants.AddAsync(newTenant);
                await context.SaveChangesAsync();

                return Results.Redirect($"/user/checkInfo/{newTenant.id}");
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
                var tenant = await context.Tenants.FindAsync(requestUpdateTenant.id);

                if (tenant == null)
                {
                    return Results.NotFound();
                }

                tenant.setName(requestUpdateTenant.name);
                tenant.setEmail(requestUpdateTenant.email);
                tenant.setPhone(requestUpdateTenant.phone);
                tenant.setCPF(requestUpdateTenant.cpf);

                await context.SaveChangesAsync();

                return Results.Ok(tenant);
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
