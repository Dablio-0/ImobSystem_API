using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ImobSystem_API.Models;
using ImobSystem_API.DTOs.Houses;
using ImobSystem_API.Data;
using ImobSystem_API.DTOs.User;

namespace ImobSystem_API.Controllers
{
    public static class HouseController
    {
        public static void MapHouseRoutes(this WebApplication app)
        {
            /* Prefix House Route */
            var groupHouse = app.MapGroup("house");

            #region Create House
            groupHouse.MapPost("/create", async (AddHouseRequest requestAddHouse, AppDbContext context) =>
            {
                var newHouse = new House(requestAddHouse.address, requestAddHouse.rooms, requestAddHouse.type, requestAddHouse.zipCode);

                var checkHouseExists = await context.Houses.AnyAsync(h => h.Address == newHouse.Address);

                if (checkHouseExists)
                {
                    return Results.BadRequest("House already exists");
                }

                await context.Houses.AddAsync(newHouse);
                await context.SaveChangesAsync();

                return Results.Redirect($"/checkInfo/{newHouse.Id}");
            });
            #endregion

            #region Check House Info
            groupHouse.MapGet("/checkInfo/{id}", async (uint id, AppDbContext context) =>
            {
                var house = await context.Houses.FindAsync(id);

                if (house == null)
                {
                    return Results.NotFound("House not found.");
                }

                return Results.Ok(house);
            });
            #endregion

            #region Update House
            groupHouse.MapPut("/update/{id}", async (uint id, UpdateHouseRequest requestUpdateHouse, AppDbContext context) =>
            {
                var house = await context.Houses.FindAsync(id);

                if (house == null)
                {
                    return Results.NotFound("House not found.");
                }

                house.Address = requestUpdateHouse.address;
                house.Rooms = requestUpdateHouse.rooms;
                house.Type = requestUpdateHouse.type;
                house.ZipCode = requestUpdateHouse.zipCode;

                return Results.Ok(house);
            });
            #endregion

            #region Delete House
            groupHouse.MapDelete("/delete/{id}", async (uint id, AppDbContext context) =>
            {
                var house = await context.Houses.FindAsync(id);

                if (house == null)
                {
                    return Results.NotFound("House not found.");
                }

                context.Houses.Remove(house);
                await context.SaveChangesAsync();

                return Results.Ok("House deleted.");
            });
            #endregion

            groupHouse.MapGet("/checkTenants/${idUser}", async (uint idUser, AppDbContext context) =>
            {

            });
        }
    }
}
