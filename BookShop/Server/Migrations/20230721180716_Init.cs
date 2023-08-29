using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Editions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TextOrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "regModels",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConfirmPwd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regModels", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Visits = table.Column<int>(type: "int", nullable: false),
                    LastVisit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "camera-sir", "Телевизоры", "tv" },
                    { 2, "camera-sir", "Холодильники", "fridge" }
                });

            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Default" },
                    { 2, "Paperback" },
                    { 3, "E-Book" },
                    { 4, "Audiobook" }
                });

            migrationBuilder.InsertData(
                table: "regModels",
                columns: new[] { "Email", "Address", "ConfirmPwd", "Name", "Password", "Role", "Surname" },
                values: new object[] { "admin@admin.ru", "Admin", "$2a$11$C27HMxTt.DsulwPiJPw9I.6IUmV55MKvhulZrDMq.7Npy7N.YxQny", "Admin", "$2a$11$tlb4BCJV9W1FehsLY644AuEhBZg3F7HVwx.f2.4v4fSkzNJBjPEmi", 0, "Admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "Title", "Views" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 21, 18, 7, 15, 860, DateTimeKind.Utc).AddTicks(9438), null, "Reproduces over a billion accurate colors resulting in picture quality that is natural and precise, and closer than ever to real life, enhanced by TRILUMINOS Pro.", "https://m.media-amazon.com/images/I/8127maI-DWL._AC_UY218_.jpg", "Sony 65 Inch 4K Ultra HD TV X80K", 0 },
                    { 2, 1, new DateTime(2023, 7, 21, 18, 7, 15, 860, DateTimeKind.Utc).AddTicks(9450), null, "Experience the magic of the big screen right from your couch. Every LG OLED comes loaded with Dolby Vision for extraordinary color, contrast and brightness, plus Dolby Atmos* for wrap-around sound. Land in the center of the action with LG's FILMMAKER MODE, allowing you to see films just as the director intended. ", "https://m.media-amazon.com/images/I/61fdYYpVYIL._AC_UY218_.jpg", "LG C3 Series 55-Inch Class OLED evo Smart TV OLED55C3PUA", 0 },
                    { 3, 2, new DateTime(2023, 7, 21, 18, 7, 15, 860, DateTimeKind.Utc).AddTicks(9453), null, "Enjoy the sleek throwback design and vibrant color of this COMMERCIAL COOL retro refrigerator (21.5” x 23” x 35.2”) while relishing its modern-day functionality. Complete with 4.0 cubic feet of storage and a stylish chrome plated door handle, our vintage style refrigerator (68.1 lbs.) combines old school charm with contemporary capabilities in three colors—cool red, sleek black, and stunning white. ", "https://m.media-amazon.com/images/I/51C83H1qy6L._AC_UY218_.jpg", "Commercial Cool CCRR4LR 4.0 Cu. Ft Freezer", 0 },
                    { 4, 2, new DateTime(2023, 7, 21, 18, 7, 15, 860, DateTimeKind.Utc).AddTicks(9455), null, "Vintage Coca-Cola Style: Featuring the iconic contoured glass bottle first introduced over 100 years ago, this vibrant red mini-fridge is a keystone piece for Coke memorabilia fans and collectors! ", "https://m.media-amazon.com/images/I/61ZnUOtbK7L._AC_SX569_.jpg", "Coca-Cola Classic Coke Bottle 4L Mini Fridge w/ 12V DC and 110V AC Cords", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 165m, 140m },
                    { 1, 2, 189m, 170m },
                    { 1, 3, 307m, 285m },
                    { 1, 4, 73m, 64m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_EditionId",
                table: "ProductVariant",
                column: "EditionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DropTable(
                name: "regModels");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Editions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
