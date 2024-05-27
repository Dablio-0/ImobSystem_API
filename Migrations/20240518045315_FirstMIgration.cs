using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImobSystem_API.Migrations
{
    /// <inheritdoc />
    public partial class FirstMIgration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    id = table.Column<uint>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.id);
                    table.ForeignKey(
                        name: "FK_Houses_Agreements_id",
                        column: x => x.id,
                        principalTable: "Agreements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgreementTenant",
                columns: table => new
                {
                    Agreementsid = table.Column<uint>(type: "INTEGER", nullable: false),
                    Tenantsid = table.Column<uint>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementTenant", x => new { x.Agreementsid, x.Tenantsid });
                    table.ForeignKey(
                        name: "FK_AgreementTenant_Agreements_Agreementsid",
                        column: x => x.Agreementsid,
                        principalTable: "Agreements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgreementTenant_Tenants_Tenantsid",
                        column: x => x.Tenantsid,
                        principalTable: "Tenants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwner",
                columns: table => new
                {
                    Housesid = table.Column<uint>(type: "INTEGER", nullable: false),
                    Ownersid = table.Column<uint>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwner", x => new { x.Housesid, x.Ownersid });
                    table.ForeignKey(
                        name: "FK_HouseOwner_Houses_Housesid",
                        column: x => x.Housesid,
                        principalTable: "Houses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseOwner_Owners_Ownersid",
                        column: x => x.Ownersid,
                        principalTable: "Owners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreementTenant_Tenantsid",
                table: "AgreementTenant",
                column: "Tenantsid");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwner_Ownersid",
                table: "HouseOwner",
                column: "Ownersid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreementTenant");

            migrationBuilder.DropTable(
                name: "HouseOwner");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Agreements");
        }
    }
}
