using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededDataToGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "IdGenre", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "Comedy" },
                    { 4, "Crime" },
                    { 5, "Drama" },
                    { 6, "Fantasy" },
                    { 7, "Historical" },
                    { 8, "Horror" },
                    { 9, "Mystery" },
                    { 10, "Romance" },
                    { 11, "Science Fiction" },
                    { 12, "Thriller" },
                    { 13, "Western" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 13);
        }
    }
}
