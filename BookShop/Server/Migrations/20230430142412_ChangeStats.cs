using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookShop.Server.Migrations
{
    public partial class ChangeStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stats",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Stats");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Stats",
                newName: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stats",
                table: "Stats",
                column: "Email");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 30, 14, 24, 12, 127, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 30, 14, 24, 12, 127, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 30, 14, 24, 12, 127, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 30, 14, 24, 12, 127, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 30, 14, 24, 12, 127, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 30, 14, 24, 12, 127, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "regModels",
                keyColumn: "Email",
                keyValue: "admin@admin.ru",
                columns: new[] { "ConfirmPwd", "Password" },
                values: new object[] { "$2a$11$OtaI46cOKPgge153Yd1XxOfFaQMwGErFBXiWSQRJ2gItsu9ybmSGG", "$2a$11$SR5VSWGcGdkzEtu6bwtR6Oil9ggIul5SE.TSGiPRlLBmtlX5ITgVm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stats",
                table: "Stats");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Stats",
                newName: "Username");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Stats",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stats",
                table: "Stats",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 14, 38, 52, 23, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 14, 38, 52, 23, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 14, 38, 52, 23, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 14, 38, 52, 23, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 14, 38, 52, 23, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 14, 38, 52, 23, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "regModels",
                keyColumn: "Email",
                keyValue: "admin@admin.ru",
                columns: new[] { "ConfirmPwd", "Password" },
                values: new object[] { "$2a$11$jaTqHPH4/9Gei4F80r6pleShrh4qRS7xC/ldMUTywC9YbJSWZWmgy", "$2a$11$KlOuVdKwlQdelgf9qpnAYOKq9JlCrqgQ3nSHHbCDxSIyZw6zdguye" });
        }
    }
}
