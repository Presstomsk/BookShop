using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Server.Migrations
{
    public partial class CorrectProductVariant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 2.12m, 1.50m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 2.12m, 1.50m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 15.15m, 10.00m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 5.20m, 4.20m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 4.15m, 3.50m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 11.35m, 8.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 14.37m, 12.00m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 12.00m, 9.00m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 51.00m, 47.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 14.48m, 12.15m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 9.99m, 7.50m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.82m, 17.00m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 13.83m, 11.70m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 10.99m, 9.50m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 37.07m, 27.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 11.49m, 9.15m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 9.49m, 7.13m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 25.50m, 22.99m });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 1.50m, 2.12m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 1.50m, 2.12m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 10.00m, 15.15m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 4.20m, 5.20m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 3.50m, 4.15m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 8.99m, 11.35m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 12.00m, 14.37m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 9.00m, 12.00m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 47.99m, 51.00m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 12.15m, 14.48m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 7.50m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 17.00m, 19.82m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 11.70m, 13.83m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 9.50m, 10.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 27.99m, 32.07m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 9.15m, 11.49m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 7.13m, 9.49m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 22.99m, 25.50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "regModels",
                keyColumn: "Email",
                keyValue: "admin@admin.ru",
                columns: new[] { "ConfirmPwd", "Password" },
                values: new object[] { "$2a$11$9PHzspKA4nsPlHsaVIZLqOW53onHg/ASSRhfjZILtHHbJTEf9fxwC", "$2a$11$i.oz/iIp2H2aenVAJXzO4eCjdsxjF6f0UyaOJJWsZtuFqouDNGVFW" });
        }
    }
}
