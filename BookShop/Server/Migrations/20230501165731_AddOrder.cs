using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Server.Migrations
{
    public partial class AddOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 1, 16, 57, 30, 719, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 1, 16, 57, 30, 719, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 1, 16, 57, 30, 719, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 5, 1, 16, 57, 30, 719, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 5, 1, 16, 57, 30, 719, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 5, 1, 16, 57, 30, 719, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "regModels",
                keyColumn: "Email",
                keyValue: "admin@admin.ru",
                columns: new[] { "ConfirmPwd", "Password" },
                values: new object[] { "$2a$11$0GtBKE2aTmI.tJ23Az7Ns.qCkQ/80biPTqi9uyzpa9EhGniv2jM6m", "$2a$11$jVUtFy/XCA0vlrR25y8ySunXeeSYP7sr88EEsSRfCfCWZjI1SXTsO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
