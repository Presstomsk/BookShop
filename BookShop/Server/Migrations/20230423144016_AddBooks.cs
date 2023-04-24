using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Server.Migrations
{
    public partial class AddBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Романтика", "romantic" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 2, "book", "Биография", "biography" },
                    { 3, "book", "Кулинария", "cookbooks" }
                });

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Description", "Image", "Title" },
                values: new object[] { new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(412), "Kenna Brown leaves prison after serving five years and tries to connect with her four-year-old daughter.", "https://a.allegroimg.com/s512/25ab2d/f78b89344b9e8aac238f8badf1eb/REMINDERS-OF-HIM-CZASTKA-CIEBIE-KTORA-ZNAM-Hoover", "Reminders of Him\r\nby Colleen Hoover" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Description", "Image", "Title" },
                values: new object[] { new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(421), "Sky, 17, fights her feelings for Dean, a boy who is not what he appears to be.", "https://m.media-amazon.com/images/I/71ZnF9mTahL._AC_UF1000,1000_QL80_.jpg", "Hopeless\r\nby Colleen Hoover" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Description", "Image", "Title" },
                values: new object[] { new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(423), "After being laid off from her job, Carmen moves in with her successful sister Sofia.", "https://m.media-amazon.com/images/I/71c43tpsEaL.jpg", "The Christmas Bookshop\r\nby Jenny Colgan" });

            migrationBuilder.InsertData(
                table: "regModels",
                columns: new[] { "Email", "Address", "ConfirmPwd", "Name", "Password", "Role", "Surname" },
                values: new object[] { "admin@admin.ru", "Admin", "$2a$11$9PHzspKA4nsPlHsaVIZLqOW53onHg/ASSRhfjZILtHHbJTEf9fxwC", "Admin", "$2a$11$i.oz/iIp2H2aenVAJXzO4eCjdsxjF6f0UyaOJJWsZtuFqouDNGVFW", 0, "Admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "Title", "Views" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(425), null, "Subtitle: \"Overcoming in Uncertain Times\"", "https://m.media-amazon.com/images/I/81YGTQ33HnL.jpg", false, "The Light We Carry\r\nby Michelle Obama", 0 },
                    { 5, 2, new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(426), null, "The actor takes fans behind the scenes of \"Friends\" and opens up about his struggle with addiction and a life-threatening health scare.", "https://m.media-amazon.com/images/I/81tdvyI0MeL.jpg", false, "Friends, Lovers, and the Big Terrible Thing\r\nby Matthew Perry", 0 },
                    { 6, 3, new DateTime(2023, 4, 23, 14, 40, 16, 149, DateTimeKind.Utc).AddTicks(430), null, "Subtitle: \"A Barefoot Contessa Cookbook\"", "https://m.media-amazon.com/images/I/81vsGXDc+FL._AC_UF1000,1000_QL80_.jpg", false, "Go-To Dinners\r\nby Ina Garten", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 2, 4, 12.15m, 14.48m },
                    { 3, 4, 7.50m, 9.99m },
                    { 4, 4, 17.00m, 19.82m },
                    { 2, 5, 11.70m, 13.83m },
                    { 3, 5, 9.50m, 10.99m },
                    { 4, 5, 27.99m, 32.07m },
                    { 2, 6, 9.15m, 11.49m },
                    { 3, 6, 7.13m, 9.49m },
                    { 4, 6, 22.99m, 25.50m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "regModels",
                keyColumn: "Email",
                keyValue: "admin@admin.ru");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Books", "books" });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 60.99m, 50.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 40.99m, 30.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 50.99m, 40.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 60.99m, 50.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 40.99m, 30.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 50.99m, 40.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 60.99m, 50.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 40.99m, 30.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 50.99m, 40.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Description", "Image", "Title" },
                values: new object[] { new DateTime(2023, 4, 23, 10, 30, 54, 5, DateTimeKind.Utc).AddTicks(3596), "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Description", "Image", "Title" },
                values: new object[] { new DateTime(2023, 4, 23, 10, 30, 54, 5, DateTimeKind.Utc).AddTicks(3607), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Description", "Image", "Title" },
                values: new object[] { new DateTime(2023, 4, 23, 10, 30, 54, 5, DateTimeKind.Utc).AddTicks(3609), "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" });
        }
    }
}
