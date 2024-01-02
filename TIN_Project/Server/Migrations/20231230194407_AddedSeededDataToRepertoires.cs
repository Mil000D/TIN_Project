using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededDataToRepertoires : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Day",
                table: "Repertoires",
                newName: "Date");

            migrationBuilder.InsertData(
                table: "Repertoires",
                columns: new[] { "IdRepertoire", "Date", "IdCinema" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 12, 31), 1 },
                    { 2, new DateOnly(2024, 1, 1), 1 },
                    { 3, new DateOnly(2024, 1, 2), 1 },
                    { 4, new DateOnly(2024, 1, 3), 1 },
                    { 5, new DateOnly(2024, 1, 4), 1 },
                    { 6, new DateOnly(2023, 12, 31), 2 },
                    { 7, new DateOnly(2024, 1, 1), 2 },
                    { 8, new DateOnly(2024, 1, 2), 2 },
                    { 9, new DateOnly(2024, 1, 3), 2 },
                    { 10, new DateOnly(2024, 1, 4), 2 },
                    { 11, new DateOnly(2023, 12, 31), 3 },
                    { 12, new DateOnly(2024, 1, 1), 3 },
                    { 13, new DateOnly(2024, 1, 2), 3 },
                    { 14, new DateOnly(2024, 1, 3), 3 },
                    { 15, new DateOnly(2024, 1, 4), 3 },
                    { 16, new DateOnly(2023, 12, 31), 4 },
                    { 17, new DateOnly(2024, 1, 1), 4 },
                    { 18, new DateOnly(2024, 1, 2), 4 },
                    { 19, new DateOnly(2024, 1, 3), 4 },
                    { 20, new DateOnly(2024, 1, 4), 4 },
                    { 21, new DateOnly(2023, 12, 31), 5 },
                    { 22, new DateOnly(2024, 1, 1), 5 },
                    { 23, new DateOnly(2024, 1, 2), 5 },
                    { 24, new DateOnly(2024, 1, 3), 5 },
                    { 25, new DateOnly(2024, 1, 4), 5 },
                    { 26, new DateOnly(2023, 12, 31), 6 },
                    { 27, new DateOnly(2024, 1, 1), 6 },
                    { 28, new DateOnly(2024, 1, 2), 6 },
                    { 29, new DateOnly(2024, 1, 3), 6 },
                    { 30, new DateOnly(2024, 1, 4), 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 30);

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Repertoires",
                newName: "Day");
        }
    }
}
