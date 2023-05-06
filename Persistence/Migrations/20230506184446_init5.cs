using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adresss",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ContactPersonId",
                table: "Offers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedCloseDate",
                table: "Offers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OfferStage",
                table: "Offers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Offers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Offers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Offers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValueType",
                table: "Offers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Visibility",
                table: "Offers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ContactPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ContactPersonId",
                table: "Offers",
                column: "ContactPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_OrganizationId",
                table: "Offers",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_ContactPerson_ContactPersonId",
                table: "Offers",
                column: "ContactPersonId",
                principalTable: "ContactPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Organization_OrganizationId",
                table: "Offers",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_ContactPerson_ContactPersonId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Organization_OrganizationId",
                table: "Offers");

            migrationBuilder.DropTable(
                name: "ContactPerson");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Offers_ContactPersonId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_OrganizationId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "ContactPersonId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "ExpectedCloseDate",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "OfferStage",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "ValueType",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "Offers");

            migrationBuilder.AddColumn<string>(
                name: "Adresss",
                table: "AspNetUsers",
                type: "text",
                nullable: true);
        }
    }
}
