using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Est neque reiciendis explicabo dolores eius earum ea velit. Mollitia blanditiis voluptates. Velit dolorem sunt ducimus quo id et fuga ea.", "ex" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Voluptas harum quo ipsa et. Modi tenetur maiores dolorem velit dolorem error earum et. Quod velit est eligendi consequatur doloremque ea dicta maiores. Quam corporis omnis non et quaerat ullam.", "repudiandae" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A eum et unde. Id laborum aliquam qui et cumque. Accusamus ad eum qui.", "voluptate" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Qui quod eveniet ut enim aut aspernatur illo neque. Praesentium numquam voluptas eum placeat et cum deserunt sit sunt. Ducimus ut vitae consequatur. Veritatis fuga necessitatibus.", "ut" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ut alias beatae adipisci quaerat numquam architecto consequatur. Cum iste repellendus molestiae. Tenetur beatae eaque consequatur praesentium hic asperiores nisi.", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Necessitatibus saepe animi et est ipsa atque error. Ab eius suscipit. Similique sunt ipsam totam assumenda veritatis rerum. Dignissimos odit vero qui repellat sunt sed. Beatae laborum ut necessitatibus ut quo dolor.", "quia" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Natus ratione sint cum quidem. Perspiciatis provident ipsam id qui. A enim nam natus odit nulla rerum. Reiciendis omnis perspiciatis molestiae enim cum sint dolores qui. Maxime ullam velit quisquam esse sed. Sunt voluptatem rerum non ut aut sit ut minima.", "odit" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Voluptatem qui maxime quasi qui et sit. Dicta ipsam non soluta ut voluptatem. Enim unde sed consequatur dolor aut cupiditate amet. Nesciunt enim quis et consequatur dolorem officiis vel dolorem distinctio. In ullam saepe eius et id voluptas modi vero sit.", "quo" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Doloremque quam omnis ut delectus eos fugit sit placeat. Voluptas aut iure odio ipsa. Et odio sint laudantium esse qui.", "ut" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Totam qui in quia quia recusandae ullam incidunt ad. Ut explicabo consequatur. Amet sint voluptatibus praesentium optio harum quia consequatur et. Omnis vel occaecati ut illo voluptate. Rerum aut voluptatem molestias qui provident est. Optio quae omnis et aut.", "dolores" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Togo", "Veum, Jenkins and Stanton" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Ukraine", "Beer LLC" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Central African Republic", "Waters, Abbott and Grant" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Central African Republic", "Mayert, Hills and Senger" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Germany", "Cole and Sons" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Jersey", "Grimes - Kemmer" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Sao Tome and Principe", "Pollich - Raynor" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Nauru", "Larkin Group" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Italy", "Glover, Bruen and Quitzon" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Italy", "O'Kon, Spencer and Nikolaus" });

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufacturerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufacturerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 5,
                column: "ManufacturerId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 6,
                column: "ManufacturerId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 7,
                column: "ManufacturerId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 8,
                column: "ManufacturerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 9,
                column: "ManufacturerId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 10,
                column: "ManufacturerId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 4, "Model 3", 308 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 5, "ATS", 425 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 4, "Fiesta", 345 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 4, "Countach", 267 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 10, "Volt", 153 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 2, "A8", 211 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 2, "ATS", 355 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 6, "LeBaron", 314 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 2, "Aventador", 290 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 6, "Charger", 292 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Rerum quibusdam excepturi doloribus dicta voluptates. Earum vero quasi sed architecto quod omnis. Debitis odit sunt natus cum eos et atque sunt a.", "Challenger" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Deserunt officiis qui voluptates. Deserunt aut qui magnam quis incidunt nihil. Quia neque magni sed animi sit aut natus culpa non.", "Wrangler" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Modi perferendis et suscipit sed eius laboriosam rerum. Praesentium vel voluptates est suscipit tempore. Dolor unde voluptatem.", "El Camino" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Dicta similique possimus voluptatem deserunt eveniet sit. Voluptatum praesentium labore. Aut et et. Totam velit enim sint omnis voluptatem. Sit iusto velit repellendus natus cupiditate vero unde. Ad qui ullam voluptatem quam voluptatibus et eveniet quibusdam sint.", "A8" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ullam dolor porro nostrum expedita est sunt ratione. Voluptatibus itaque et asperiores ipsam odio consequatur quas accusantium. Consequuntur labore repellendus autem repellendus.", "XC90" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Minima tempora officia ea officiis reprehenderit numquam minima optio. Aut sit provident quidem esse optio consequuntur quia est. Odio vitae accusamus soluta. Minus qui et. Animi eum quaerat sunt placeat dolorem ut enim quo.", "XC90" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Consequatur voluptates dolor. Quia vel dolor. Non quibusdam explicabo consequatur culpa quia. Molestias ex facilis. Dolores aliquam a veritatis et est corporis porro placeat molestias.", "Charger" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Inventore et voluptas. Consequatur voluptatem sapiente dolor quia atque quisquam et. Architecto temporibus quia vel ex dignissimos voluptatem in quaerat est.", "Cruze" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Deleniti cumque ut ab aperiam ducimus suscipit nobis eveniet. Consequatur qui voluptatem veritatis in debitis quisquam unde aut est. Fuga sint nemo at sit in. Ut eaque maxime sit dicta ut tenetur voluptatum. Consequatur nobis dignissimos et culpa officiis pariatur velit doloremque quaerat. Totam eius excepturi dolorem adipisci magnam corrupti facere aliquid.", "Malibu" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sint illum laborum eaque nemo. Et molestiae hic voluptas illum perspiciatis ut velit vitae. Eveniet rem cumque. Eos ab ut ratione.", "Silverado" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Ghana", "Lesch - Waters" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Virgin Islands, U.S.", "Stamm LLC" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Gabon", "Bernhard and Sons" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "Name" },
                values: new object[] { "French Guiana", "Strosin, Botsford and Barrows" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Fiji", "Nitzsche - Ernser" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Kenya", "Gibson Inc" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Peru", "Corwin Inc" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Christmas Island", "Murazik LLC" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Christmas Island", "Goodwin - Huel" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Chad", "Hirthe, Denesik and Adams" });

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufacturerId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufacturerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 5,
                column: "ManufacturerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 6,
                column: "ManufacturerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 7,
                column: "ManufacturerId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 8,
                column: "ManufacturerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 9,
                column: "ManufacturerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 10,
                column: "ManufacturerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 7, "Civic", 182 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 9, "XC90", 238 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 6, "Accord", 302 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 5, "Model S", 363 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 3, "Prius", 284 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 5, "A4", 131 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 5, "Wrangler", 191 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 8, "Countach", 105 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 10, "Taurus", 244 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 10, "Land Cruiser", 365 });
        }
    }
}
