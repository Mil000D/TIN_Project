using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModelsAndSeededDataInGenresAndMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "PolishTitle");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "PolishDescription");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "EnglishName");

            migrationBuilder.AddColumn<string>(
                name: "EnglishDescription",
                table: "Movies",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishTitle",
                table: "Movies",
                type: "TEXT",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PolishName",
                table: "Genres",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 1,
                column: "PolishName",
                value: "Akcja");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 2,
                column: "PolishName",
                value: "Przygodowy");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 3,
                column: "PolishName",
                value: "Komedia");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 4,
                column: "PolishName",
                value: "Kryminalny");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 5,
                column: "PolishName",
                value: "Dramat");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 6,
                column: "PolishName",
                value: "Fantasy");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 7,
                column: "PolishName",
                value: "Historyczny");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 8,
                column: "PolishName",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 9,
                column: "PolishName",
                value: "Tajemnica");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 10,
                column: "PolishName",
                value: "Romans");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 11,
                column: "PolishName",
                value: "Science Fiction");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 12,
                column: "PolishName",
                value: "Thriller");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "IdGenre",
                keyValue: 13,
                column: "PolishName",
                value: "Western");

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 1,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2283)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 2,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2355)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 3,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2357)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 4,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2360)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 5,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2362)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 6,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2364)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 7,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2366)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 8,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2368)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 9,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2370)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 10,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2372)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 11,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2374)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 12,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2376)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 13,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2378)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 14,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2380)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 15,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2382)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 16,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2384)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 17,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2385)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 18,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2387)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 19,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2389)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 20,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2391)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 21,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2393)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 22,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2395)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 23,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2397)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 24,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2399)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 25,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2401)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 26,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2403)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 27,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2405)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 28,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2407)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 29,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2409)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 30,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2410)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 31,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2412)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 32,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2414)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 33,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2416)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 34,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2418)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 35,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2420)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 36,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2422)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 37,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2424)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 38,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2426)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 39,
                column: "ShowTime",
                value: new TimeOnly(17, 49, 16, 990).Add(TimeSpan.FromTicks(2428)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 40,
                column: "ShowTime",
                value: new TimeOnly(18, 49, 16, 990).Add(TimeSpan.FromTicks(2430)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 41,
                column: "ShowTime",
                value: new TimeOnly(15, 49, 16, 990).Add(TimeSpan.FromTicks(2432)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 42,
                column: "ShowTime",
                value: new TimeOnly(16, 49, 16, 990).Add(TimeSpan.FromTicks(2433)));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 1,
                columns: new[] { "EnglishDescription", "EnglishTitle", "PolishDescription", "PolishTitle" },
                values: new object[] { "A team of superheroes save the world from a powerful threat.", "The Avengers", "Zespół superbohaterów ratuje świat przed potężnym zagrożeniem.", "Avengers" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 2,
                columns: new[] { "EnglishDescription", "EnglishTitle", "PolishDescription", "PolishTitle" },
                values: new object[] { "A thief enters people's dreams to steal information.", "Inception", "Złodziej wkracza do snów ludzi, aby ukraść informacje.", "Incepcja" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 3,
                columns: new[] { "EnglishDescription", "EnglishTitle", "PolishDescription", "PolishTitle" },
                values: new object[] { "A vigilante fights crime in Gotham City.", "The Dark Knight", "Samozwańczy sprawiedliwy walczy ze złem w Gotham City.", "Mroczny Rycerz" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 4,
                columns: new[] { "EnglishDescription", "EnglishTitle", "PolishDescription", "PolishTitle" },
                values: new object[] { "A hobbit embarks on a journey to destroy a powerful ring.", "The Lord of the Rings: The Fellowship of the Ring", "Hobbit wyrusza w podróż, aby zniszczyć potężny pierścień.", "Władca Pierścieni: Drużyna Pierścienia" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 5,
                columns: new[] { "EnglishDescription", "EnglishTitle", "PolishDescription", "PolishTitle" },
                values: new object[] { "A hacker discovers that the world is a simulation.", "The Matrix", "Haker odkrywa, że świat jest symulacją.", "Matrix" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 6,
                columns: new[] { "EnglishDescription", "EnglishTitle", "PolishDescription" },
                values: new object[] { "Various interconnected stories of criminals, lowlifes, and a mysterious briefcase.", "Pulp Fiction", "Różne powiązane ze sobą historie kryminalistów, łotrów i tajemniczej walizki." });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 7,
                columns: new[] { "EnglishDescription", "EnglishTitle", "PolishDescription", "PolishTitle" },
                values: new object[] { "A freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.", "Django Unchained", "Uwolniony niewolnik wyrusza, aby uratować swoją żonę przed brutalnym właścicielem plantacji w Missisipi.", "Django" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 3,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 4,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 5,
                column: "Date",
                value: new DateOnly(2024, 1, 14));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 6,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 7,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 8,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 9,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 10,
                column: "Date",
                value: new DateOnly(2024, 1, 14));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 11,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 12,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 13,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 14,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 15,
                column: "Date",
                value: new DateOnly(2024, 1, 14));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 16,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 17,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 18,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 19,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 20,
                column: "Date",
                value: new DateOnly(2024, 1, 14));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 21,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 22,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 23,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 24,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 25,
                column: "Date",
                value: new DateOnly(2024, 1, 14));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 26,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 27,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 28,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 29,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 30,
                column: "Date",
                value: new DateOnly(2024, 1, 14));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnglishDescription",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "EnglishTitle",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "PolishName",
                table: "Genres");

            migrationBuilder.RenameColumn(
                name: "PolishTitle",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "PolishDescription",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "Genres",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 1,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5318)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 2,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5389)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 3,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5392)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 4,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5394)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 5,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5396)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 6,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5398)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 7,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5401)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 8,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5402)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 9,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5404)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 10,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5407)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 11,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5409)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 12,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5410)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 13,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5412)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 14,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5414)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 15,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5416)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 16,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5418)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 17,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5420)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 18,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5422)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 19,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5424)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 20,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5426)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 21,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5428)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 22,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5430)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 23,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5432)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 24,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5434)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 25,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5436)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 26,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5438)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 27,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5440)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 28,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5442)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 29,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5444)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 30,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5446)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 31,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5448)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 32,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5450)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 33,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5452)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 34,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5453)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 35,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5455)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 36,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5457)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 37,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5459)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 38,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5461)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 39,
                column: "ShowTime",
                value: new TimeOnly(2, 18, 31, 665).Add(TimeSpan.FromTicks(5463)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 40,
                column: "ShowTime",
                value: new TimeOnly(3, 18, 31, 665).Add(TimeSpan.FromTicks(5465)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 41,
                column: "ShowTime",
                value: new TimeOnly(0, 18, 31, 665).Add(TimeSpan.FromTicks(5467)));

            migrationBuilder.UpdateData(
                table: "MovieRepertoires",
                keyColumn: "IdMovieRepertoire",
                keyValue: 42,
                column: "ShowTime",
                value: new TimeOnly(1, 18, 31, 665).Add(TimeSpan.FromTicks(5469)));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A team of superheroes save the world from a powerful threat.", "The Avengers" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A thief enters people's dreams to steal information.", "Inception" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A vigilante fights crime in Gotham City.", "The Dark Knight" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A hobbit embarks on a journey to destroy a powerful ring.", "The Lord of the Rings: The Fellowship of the Ring" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A hacker discovers that the world is a simulation.", "The Matrix" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 6,
                column: "Description",
                value: "Various interconnected stories of criminals, lowlifes, and a mysterious briefcase.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.", "Django Unchained" });

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2024, 1, 9));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 3,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 4,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 5,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 6,
                column: "Date",
                value: new DateOnly(2024, 1, 9));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 7,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 8,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 9,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 10,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 11,
                column: "Date",
                value: new DateOnly(2024, 1, 9));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 12,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 13,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 14,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 15,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 16,
                column: "Date",
                value: new DateOnly(2024, 1, 9));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 17,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 18,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 19,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 20,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 21,
                column: "Date",
                value: new DateOnly(2024, 1, 9));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 22,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 23,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 24,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 25,
                column: "Date",
                value: new DateOnly(2024, 1, 13));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 26,
                column: "Date",
                value: new DateOnly(2024, 1, 9));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 27,
                column: "Date",
                value: new DateOnly(2024, 1, 10));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 28,
                column: "Date",
                value: new DateOnly(2024, 1, 11));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 29,
                column: "Date",
                value: new DateOnly(2024, 1, 12));

            migrationBuilder.UpdateData(
                table: "Repertoires",
                keyColumn: "IdRepertoire",
                keyValue: 30,
                column: "Date",
                value: new DateOnly(2024, 1, 13));
        }
    }
}
