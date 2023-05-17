using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class BetterFoodNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Nihil doloribus et repellendus maxime nobis. Repellat ducimus enim. Quia eaque alias rerum sed.", "Sushi" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sed officia nostrum quidem dolores non sint vel. Aut dolorem aut et quia ipsam rerum molestiae facilis. Sit nobis quod dicta dolores aspernatur aperiam. Harum officiis accusantium quae. Odit ut autem omnis quia ut ducimus quos sequi.", "Sushi" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Est laudantium accusamus eligendi est adipisci nostrum est et. Mollitia ut doloribus doloremque. Voluptas nobis ratione cupiditate.", "Kebab" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Possimus quaerat eaque labore culpa cum eum ipsam eos assumenda. Voluptatem sapiente illo cum est tenetur excepturi molestiae necessitatibus dolor. Et sint nihil enim. Tempora sit laudantium et vel. Nulla omnis quia quasi quis quia sint omnis dolores. Nihil optio consequatur.", "Kebab" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Maxime maiores itaque ut. Non error aliquid. Quis aut saepe expedita sunt ut commodi fugiat unde. Temporibus laboriosam sed qui. Quod omnis alias quasi assumenda est reprehenderit. Reiciendis totam sed esse deserunt enim quam dicta.", "Pizza" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Quis sit voluptatum aut ut ut et labore. Eveniet aut pariatur dolore. Expedita similique et optio assumenda cupiditate voluptatem. Odit est non ea eos reiciendis libero. In ut et impedit.", "Burger" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Quo ea neque rerum incidunt iusto vel quam autem. Ipsa sed eius. Minus tempore eius non. Molestiae qui reprehenderit earum reprehenderit deleniti. Cumque quia nesciunt est quisquam aliquam architecto tenetur. Voluptas libero velit quibusdam est.", "Kebab" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sit molestias dolorum aperiam et quia. Possimus ea sunt ut illo odio. Nam excepturi aspernatur. Eos a tenetur aut quia praesentium fugit.", "Sushi" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "At eos enim est amet qui magnam qui incidunt. Debitis ipsam ad et. Vitae ipsam id autem commodi. Qui et quas est. Cupiditate asperiores distinctio aut commodi molestias debitis ratione asperiores ratione.", "Fries" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Et architecto ut. Sint sit qui quas quod. Commodi qui fugiat voluptas ducimus alias et vitae.", "Coke" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Poland", "Stoltenberg - Tromp" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Guinea-Bissau", "Metz, Welch and D'Amore" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Turks and Caicos Islands", "Legros LLC" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Sweden", "Leuschke - Boehm" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Zambia", "O'Connell, Lang and Nolan" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "Name" },
                values: new object[] { "India", "Borer Inc" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Location", "Name" },
                values: new object[] { "New Zealand", "Spencer, Stehr and Weber" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Brazil", "McLaughlin Group" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Netherlands", "Kilback Group" });

            migrationBuilder.UpdateData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Algeria", "Wolf - Cartwright" });

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufacturerId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufacturerId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 5,
                column: "ManufacturerId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 6,
                column: "ManufacturerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 7,
                column: "ManufacturerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 8,
                column: "ManufacturerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 9,
                column: "ManufacturerId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ManufacturerFood",
                keyColumn: "Id",
                keyValue: 10,
                column: "ManufacturerId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 10, "Grand Cherokee", 433 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 7, "LeBaron", 191 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Speed" },
                values: new object[] { "Jetta", 125 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 2, "Colorado", 95 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 4, "Mustang", 155 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 3, "XTS", 339 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Speed" },
                values: new object[] { "Mustang", 276 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 9, "Taurus", 25 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ManufacturerId", "Name", "Speed" },
                values: new object[] { 9, "CX-9", 445 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Speed" },
                values: new object[] { "Golf", 268 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Name", "Speed" },
                values: new object[] { "Fiesta", 345 });

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
                columns: new[] { "Name", "Speed" },
                values: new object[] { "ATS", 355 });

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
                columns: new[] { "Name", "Speed" },
                values: new object[] { "Charger", 292 });
        }
    }
}
