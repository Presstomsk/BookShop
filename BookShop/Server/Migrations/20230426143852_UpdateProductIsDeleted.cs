using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Server.Migrations
{
    public partial class UpdateProductIsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 15, 27, 53, 148, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 15, 27, 53, 148, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 15, 27, 53, 148, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 15, 27, 53, 148, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 15, 27, 53, 148, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 15, 27, 53, 148, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "regModels",
                keyColumn: "Email",
                keyValue: "admin@admin.ru",
                columns: new[] { "ConfirmPwd", "Password" },
                values: new object[] { "$2a$11$AFMQ/mlQoceInRoeh0VDJOZShUi55T18NM/ZySBtUq/Y3jYRoItuu", "$2a$11$8FGNYDbQhnknws8ZmjQ6buKWrkn504xW6.LAJUaT2tTN9MDgvZ2uO" });
        }
    }
}
