using ImobSystem_API.Data;
using ImobSystem_API.DTOs.Agreement;
using ImobSystem_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ImobSystem_API.Controllers
{
    public static class AgreementController
    {
        public static void MapAgreementRoutes(this WebApplication app)
        {
            /* Prefix Agreement Route */
            var groupAgreement = app.MapGroup("agreement");

            /* Create Agreement */
            groupAgreement.MapPost("/create", async (AddAgreementRequest
                requestAddAgreement, AppDbContext context) =>
            {
                var newAgreement = new Agreement(
                    requestAddAgreement.owner,
                    requestAddAgreement.tenant,
                    requestAddAgreement.description,
                    requestAddAgreement.valueAgreement,
                    requestAddAgreement.numInstallments,
                    requestAddAgreement.updateAt,
                    requestAddAgreement.initDateAgreement,
                    requestAddAgreement.finalDateAgreement,
                    requestAddAgreement.House
                    );

                var checkAgreementExists = await context.Agreements.AnyAsync(a => a.Id == newAgreement.Id);

                if (checkAgreementExists)
                {
                    return Results.BadRequest("Agreement already exists");
                }

                await context.Agreements.AddAsync(newAgreement);
                await context.SaveChangesAsync();

                return Results.Ok();
            });

            /* Check yourself user info */
            groupAgreement.MapGet("/checkInfo/{id}", async (uint id, AppDbContext context) =>
            {
                var user = await context.Agreements.FindAsync(id);

                if (user == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(user);
            });

            /* Update Agreement */
            groupAgreement.MapPut("/update/{id}", async (uint id, UpdateAgreementRequest requestUpdateAgreement, AppDbContext context) =>
            {
                var agreement = await context.Agreements.FindAsync(id);

                if (agreement == null)
                {
                    return Results.NotFound();
                }

                await context.SaveChangesAsync();

                return Results.Ok(agreement);
            });

            /* Delete Agreement */
            groupAgreement.MapDelete("/delete/{id}", async (uint id, AppDbContext context) =>
            {
                var agreement = await context.Agreements.FindAsync(id);

                if (agreement == null)
                {
                    return Results.NotFound("Agreement not found");
                }

                context.Agreements.Remove(agreement);
                await context.SaveChangesAsync();

                return Results.Ok();
            });

            /* Get Active Agreement List */
            groupAgreement.MapGet("/checkActiveAgreements/{idUser}", async (uint idUser, AppDbContext context) =>
            {

            });

            /* Get Inactive Agreement List */
            groupAgreement.MapGet("/checkInactiveAgreements/{idUser}", async (uint idUser, AppDbContext context) =>
            {

            });
        }
    }
}
