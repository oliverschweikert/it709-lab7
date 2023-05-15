using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturerFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManufacturerFood_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManufacturerFood_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Rerum quibusdam excepturi doloribus dicta voluptates. Earum vero quasi sed architecto quod omnis. Debitis odit sunt natus cum eos et atque sunt a.", "Challenger" },
                    { 2, "Deserunt officiis qui voluptates. Deserunt aut qui magnam quis incidunt nihil. Quia neque magni sed animi sit aut natus culpa non.", "Wrangler" },
                    { 3, "Modi perferendis et suscipit sed eius laboriosam rerum. Praesentium vel voluptates est suscipit tempore. Dolor unde voluptatem.", "El Camino" },
                    { 4, "Dicta similique possimus voluptatem deserunt eveniet sit. Voluptatum praesentium labore. Aut et et. Totam velit enim sint omnis voluptatem. Sit iusto velit repellendus natus cupiditate vero unde. Ad qui ullam voluptatem quam voluptatibus et eveniet quibusdam sint.", "A8" },
                    { 5, "Ullam dolor porro nostrum expedita est sunt ratione. Voluptatibus itaque et asperiores ipsam odio consequatur quas accusantium. Consequuntur labore repellendus autem repellendus.", "XC90" },
                    { 6, "Minima tempora officia ea officiis reprehenderit numquam minima optio. Aut sit provident quidem esse optio consequuntur quia est. Odio vitae accusamus soluta. Minus qui et. Animi eum quaerat sunt placeat dolorem ut enim quo.", "XC90" },
                    { 7, "Consequatur voluptates dolor. Quia vel dolor. Non quibusdam explicabo consequatur culpa quia. Molestias ex facilis. Dolores aliquam a veritatis et est corporis porro placeat molestias.", "Charger" },
                    { 8, "Inventore et voluptas. Consequatur voluptatem sapiente dolor quia atque quisquam et. Architecto temporibus quia vel ex dignissimos voluptatem in quaerat est.", "Cruze" },
                    { 9, "Deleniti cumque ut ab aperiam ducimus suscipit nobis eveniet. Consequatur qui voluptatem veritatis in debitis quisquam unde aut est. Fuga sint nemo at sit in. Ut eaque maxime sit dicta ut tenetur voluptatum. Consequatur nobis dignissimos et culpa officiis pariatur velit doloremque quaerat. Totam eius excepturi dolorem adipisci magnam corrupti facere aliquid.", "Malibu" },
                    { 10, "Sint illum laborum eaque nemo. Et molestiae hic voluptas illum perspiciatis ut velit vitae. Eveniet rem cumque. Eos ab ut ratione.", "Silverado" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Ghana", "Lesch - Waters" },
                    { 2, "Virgin Islands, U.S.", "Stamm LLC" },
                    { 3, "Gabon", "Bernhard and Sons" },
                    { 4, "French Guiana", "Strosin, Botsford and Barrows" },
                    { 5, "Fiji", "Nitzsche - Ernser" },
                    { 6, "Kenya", "Gibson Inc" },
                    { 7, "Peru", "Corwin Inc" },
                    { 8, "Christmas Island", "Murazik LLC" },
                    { 9, "Christmas Island", "Goodwin - Huel" },
                    { 10, "Chad", "Hirthe, Denesik and Adams" }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerFood",
                columns: new[] { "Id", "FoodId", "ManufacturerId" },
                values: new object[,]
                {
                    { 1, 1, 9 },
                    { 2, 2, 6 },
                    { 3, 3, 4 },
                    { 4, 4, 4 },
                    { 5, 5, 3 },
                    { 6, 6, 3 },
                    { 7, 7, 6 },
                    { 8, 8, 2 },
                    { 9, 9, 1 },
                    { 10, 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "ManufacturerId", "Name", "Speed" },
                values: new object[,]
                {
                    { 1, 7, "Civic", 182 },
                    { 2, 9, "XC90", 238 },
                    { 3, 6, "Accord", 302 },
                    { 4, 5, "Model S", 363 },
                    { 5, 3, "Prius", 284 },
                    { 6, 5, "A4", 131 },
                    { 7, 5, "Wrangler", 191 },
                    { 8, 8, "Countach", 105 },
                    { 9, 10, "Taurus", 244 },
                    { 10, 10, "Land Cruiser", 365 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerFood_FoodId",
                table: "ManufacturerFood",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerFood_ManufacturerId",
                table: "ManufacturerFood",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ManufacturerId",
                table: "Vehicle",
                column: "ManufacturerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManufacturerFood");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Manufacturer");
        }
    }
}
