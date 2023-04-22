using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Server.Migrations
{
    public partial class UpdateRegModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "regModels");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "regModels");

            migrationBuilder.DropColumn(
                name: "House",
                table: "regModels");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "regModels");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "regModels");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "regModels");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "regModels",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 22, 14, 5, 44, 880, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 22, 14, 5, 44, 880, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 22, 14, 5, 44, 880, DateTimeKind.Utc).AddTicks(8411));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "regModels",
                newName: "Street");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "regModels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "regModels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "House",
                table: "regModels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "regModels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "regModels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "regModels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 20, 18, 41, 10, 497, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 20, 18, 41, 10, 497, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 20, 18, 41, 10, 497, DateTimeKind.Utc).AddTicks(5646));
        }
    }
}
