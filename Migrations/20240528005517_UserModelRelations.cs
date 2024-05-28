using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImobSystem_API.Migrations
{
    /// <inheritdoc />
    public partial class UserModelRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<uint>(
                name: "UserId",
                table: "Tenants",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "UserId",
                table: "Owners",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "UserId",
                table: "Houses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "HouseId",
                table: "Agreements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "TenantId",
                table: "Agreements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "UserId",
                table: "Agreements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_UserId",
                table: "Tenants",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_UserId",
                table: "Owners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_UserId",
                table: "Houses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_UserId",
                table: "Agreements",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agreements_Users_UserId",
                table: "Agreements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Users_UserId",
                table: "Houses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Users_UserId",
                table: "Owners",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_UserId",
                table: "Tenants",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agreements_Users_UserId",
                table: "Agreements");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Users_UserId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Users_UserId",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_UserId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_UserId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Owners_UserId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Houses_UserId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Agreements_UserId",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Agreements");
        }
    }
}
