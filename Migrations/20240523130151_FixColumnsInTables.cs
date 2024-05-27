using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImobSystem_API.Migrations
{
    /// <inheritdoc />
    public partial class FixColumnsInTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgreementTenant_Agreements_Agreementsid",
                table: "AgreementTenant");

            migrationBuilder.DropForeignKey(
                name: "FK_AgreementTenant_Tenants_Tenantsid",
                table: "AgreementTenant");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseOwner_Houses_Housesid",
                table: "HouseOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseOwner_Owners_Ownersid",
                table: "HouseOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agreements_id",
                table: "Houses");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tenants",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Owners",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Houses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Ownersid",
                table: "HouseOwner",
                newName: "OwnersId");

            migrationBuilder.RenameColumn(
                name: "Housesid",
                table: "HouseOwner",
                newName: "HousesId");

            migrationBuilder.RenameIndex(
                name: "IX_HouseOwner_Ownersid",
                table: "HouseOwner",
                newName: "IX_HouseOwner_OwnersId");

            migrationBuilder.RenameColumn(
                name: "Tenantsid",
                table: "AgreementTenant",
                newName: "TenantsId");

            migrationBuilder.RenameColumn(
                name: "Agreementsid",
                table: "AgreementTenant",
                newName: "AgreementsId");

            migrationBuilder.RenameIndex(
                name: "IX_AgreementTenant_Tenantsid",
                table: "AgreementTenant",
                newName: "IX_AgreementTenant_TenantsId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Agreements",
                newName: "Id");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Age",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateOnly>(
                name: "Age",
                table: "Tenants",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Tenants",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Tenants",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Tenants",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tenants",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Tenants",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tenants",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateOnly>(
                name: "Age",
                table: "Owners",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Owners",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Owners",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Owners",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Owners",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Owners",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Owners",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Houses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<uint>(
                name: "Rooms",
                table: "Houses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Houses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Houses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalDateAgreement",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InitDateAgreement",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<uint>(
                name: "NumInstallments",
                table: "Agreements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodAgreement",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Agreements",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ValueAgreement",
                table: "Agreements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_AgreementTenant_Agreements_AgreementsId",
                table: "AgreementTenant",
                column: "AgreementsId",
                principalTable: "Agreements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgreementTenant_Tenants_TenantsId",
                table: "AgreementTenant",
                column: "TenantsId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseOwner_Houses_HousesId",
                table: "HouseOwner",
                column: "HousesId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseOwner_Owners_OwnersId",
                table: "HouseOwner",
                column: "OwnersId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agreements_Id",
                table: "Houses",
                column: "Id",
                principalTable: "Agreements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgreementTenant_Agreements_AgreementsId",
                table: "AgreementTenant");

            migrationBuilder.DropForeignKey(
                name: "FK_AgreementTenant_Tenants_TenantsId",
                table: "AgreementTenant");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseOwner_Houses_HousesId",
                table: "HouseOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseOwner_Owners_OwnersId",
                table: "HouseOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agreements_Id",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Rooms",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "FinalDateAgreement",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "InitDateAgreement",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "NumInstallments",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "PeriodAgreement",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "ValueAgreement",
                table: "Agreements");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tenants",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Owners",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Houses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "OwnersId",
                table: "HouseOwner",
                newName: "Ownersid");

            migrationBuilder.RenameColumn(
                name: "HousesId",
                table: "HouseOwner",
                newName: "Housesid");

            migrationBuilder.RenameIndex(
                name: "IX_HouseOwner_OwnersId",
                table: "HouseOwner",
                newName: "IX_HouseOwner_Ownersid");

            migrationBuilder.RenameColumn(
                name: "TenantsId",
                table: "AgreementTenant",
                newName: "Tenantsid");

            migrationBuilder.RenameColumn(
                name: "AgreementsId",
                table: "AgreementTenant",
                newName: "Agreementsid");

            migrationBuilder.RenameIndex(
                name: "IX_AgreementTenant_TenantsId",
                table: "AgreementTenant",
                newName: "IX_AgreementTenant_Tenantsid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Agreements",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgreementTenant_Agreements_Agreementsid",
                table: "AgreementTenant",
                column: "Agreementsid",
                principalTable: "Agreements",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgreementTenant_Tenants_Tenantsid",
                table: "AgreementTenant",
                column: "Tenantsid",
                principalTable: "Tenants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseOwner_Houses_Housesid",
                table: "HouseOwner",
                column: "Housesid",
                principalTable: "Houses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseOwner_Owners_Ownersid",
                table: "HouseOwner",
                column: "Ownersid",
                principalTable: "Owners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agreements_id",
                table: "Houses",
                column: "id",
                principalTable: "Agreements",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
