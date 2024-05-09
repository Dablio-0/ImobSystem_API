using ImobSystem_API.Data;
using ImobSystem_API.DTOs.Agreement;
using ImobSystem_API.Models;

namespace ImobSystem_API.Controllers
{
    public static class AgreementController
    {
        public static void MapAgreementEndpoint(this WebApplication app)
        {
            /* Prefix Agreement Route */
            var groupAgreement = app.MapGroup("agreement");

            /* Create Agreement */
            groupAgreement.MapPost("/create", async (AddAgreementRequest requestAddAgreement, AppDbContext context) =>
            {
                var newAgreement = new Agreement(requestAddAgreement.Owner, requestAddAgreement.Tenant, requestAddAgreement.Description, requestAddAgreement.ValueAgreement, requestAddAgreement.NumInstallments, requestAddAgreement.UpdateAt, requestAddAgreement.InitDateAgreement, requestAddAgreement.FinalDateAgreement);

                var checkAgreementExists = await context.Agreements.AnyAsync(u => u.getEmail() == newAgreement.getEmail());

                if (checkAgreementExists)
                {
                    return Results.BadRequest("Agreement already exists");
                }

                await context.Agreements.AddAsync(newAgreement);
                await context.SaveChangesAsync();

                return Results.Redirect($"/user/checkInfo/{newAgreement.getId()}");
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
            groupAgreement.MapPut("/update/{id}", async (UpdateAgreementRequest requestUpdateAgreement, AppDbContext context) =>
            {
                var agreement = await context.Agreements.FindAsync(requestUpdateAgreement.id);

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
        }
    }
}
