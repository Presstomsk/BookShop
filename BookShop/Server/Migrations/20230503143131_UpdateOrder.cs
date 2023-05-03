using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Server.Migrations
{
    public partial class UpdateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TextOrderStatus",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "regModels",
                keyColumn: "Email",
                keyValue: "admin@admin.ru",
                columns: new[] { "ConfirmPwd", "Password" },
                values: new object[] { "$2a$11$LjavvJCooa2xnLd4XGlB/.ByLaRrUc1uhDFhSFjyVC65ZhUnmeQJC", "$2a$11$ULIbgWCmC5UIHza2uK8rPOiBHaBCRKF5lzxpDF7ApksdjRoH0lj/2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextOrderStatus",
                table: "Orders");

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
    }
}
