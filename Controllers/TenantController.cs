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

                var checkTenantExists = await context.Tenants.AnyAsync(t => t.Email == newTenant.Email);

                if (checkTenantExists)
                {
                    return Results.BadRequest("Tenant already exists");
                }

                await context.Tenants.AddAsync(newTenant);
                await context.SaveChangesAsync();

                return Results.Ok();
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
            groupTenant.MapPut("/update/{id}", async (uint id, UpdateTenantRequest requestUpdateTenant, AppDbContext context) =>
            {
                var tenant = await context.Tenants.FindAsync(id);

                if (tenant == null)
                {
                    return Results.NotFound();
                }

                tenant.Name = requestUpdateTenant.name;
                tenant.Email = requestUpdateTenant.email;
                tenant.Phone = requestUpdateTenant.phone;
                tenant.Cpf = requestUpdateTenant.cpf;

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

            /* Get Tenant List */
            groupTenant.MapGet("/checkTenants/{idUser}", async (uint idUser, AppDbContext context) =>
            {

            });
        }
    }
}
