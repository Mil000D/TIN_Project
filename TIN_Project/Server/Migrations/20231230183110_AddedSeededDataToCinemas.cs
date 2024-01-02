using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededDataToCinemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "IdCinema", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Złota 59, 00-120 Warszawa", "Multikino" },
                    { 2, "Wołoska 12, 02-675 Warszawa", "Cinema City" },
                    { 3, "Gen. W. Andersa 5, 00-147 Warszawa", "Kino Muranów" },
                    { 4, "Marszałkowska 28, 00-576 Warszawa", "Kino Luna" },
                    { 5, "Chmielna 33, 00-021 Warszawa", "Kino Atlantic" },
                    { 6, "Ludwika Narbutta 50A, 02-541 Warszawa", "Kino Iluzjon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "IdCinema",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "IdCinema",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "IdCinema",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "IdCinema",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "IdCinema",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "IdCinema",
                keyValue: 6);
        }
    }
}
