using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededDataToMovieRepertoires2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MovieRepertoires",
                columns: new[] { "IdMovieRepertoire", "IdMovie", "IdRepertoire", "ShowTime" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7754)) },
                    { 2, 2, 1, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7823)) },
                    { 3, 3, 1, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7826)) },
                    { 4, 4, 1, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7828)) },
                    { 5, 5, 2, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7831)) },
                    { 6, 6, 2, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7833)) },
                    { 7, 7, 2, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7835)) },
                    { 8, 1, 2, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7839)) },
                    { 9, 2, 3, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7841)) },
                    { 10, 3, 3, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7843)) },
                    { 11, 4, 3, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7845)) },
                    { 12, 5, 3, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7848)) },
                    { 13, 6, 4, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7850)) },
                    { 14, 7, 4, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7852)) },
                    { 15, 1, 4, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7855)) },
                    { 16, 2, 4, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7893)) },
                    { 17, 3, 5, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7896)) },
                    { 18, 4, 5, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7898)) },
                    { 19, 5, 5, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7901)) },
                    { 20, 6, 5, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7903)) },
                    { 21, 7, 6, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7905)) },
                    { 22, 1, 6, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7907)) },
                    { 23, 2, 6, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7910)) },
                    { 24, 3, 6, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7912)) },
                    { 25, 4, 7, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7914)) },
                    { 26, 5, 7, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7917)) },
                    { 27, 6, 7, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7919)) },
                    { 28, 7, 7, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7922)) },
                    { 29, 1, 8, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7924)) },
                    { 30, 2, 8, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7926)) },
                    { 31, 3, 8, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7928)) },
                    { 32, 4, 8, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7931)) },
                    { 33, 5, 9, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7933)) },
                    { 34, 6, 9, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7935)) },
                    { 35, 7, 9, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7937)) },
                    { 36, 1, 9, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7940)) },
                    { 37, 2, 10, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7942)) },
                    { 38, 3, 10, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7944)) },
                    { 39, 4, 10, new TimeOnly(2, 49, 23, 203).Add(TimeSpan.FromTicks(7946)) },
                    { 40, 5, 10, new TimeOnly(3, 49, 23, 203).Add(TimeSpan.FromTicks(7949)) },
                    { 41, 6, 11, new TimeOnly(0, 49, 23, 203).Add(TimeSpan.FromTicks(7951)) },
                    { 42, 7, 11, new TimeOnly(1, 49, 23, 203).Add(TimeSpan.FromTicks(7953)) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 42);
        }
    }
}
