using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededDataToMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GenreMovie",
                table: "GenreMovie");

            migrationBuilder.DropIndex(
                name: "IX_GenreMovie_MoviesIdMovie",
                table: "GenreMovie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenreMovie",
                table: "GenreMovie",
                columns: new[] { "MoviesIdMovie", "GenresIdGenre" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "IdMovie", "Description", "PosterUrl", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, "A team of superheroes save the world from a powerful threat.", "https://www.themoviedb.org/t/p/w1280/ugX4WZJO3jEvTOerctAWJLinujo.jpg", "The Avengers", "https://www.youtube.com/watch?v=eOrNdBpGMv8" },
                    { 2, "A thief enters people's dreams to steal information.", "https://www.themoviedb.org/t/p/original/aSY6QhgEeUYky0TMfAXjvRJj5bL.jpg", "Inception", "https://www.youtube.com/watch?v=YoHD9XEInc0" },
                    { 3, "A vigilante fights crime in Gotham City.", "https://www.themoviedb.org/t/p/original/qJ2tW6WMUDux911r6m7haRef0WH.jpg", "The Dark Knight", "https://www.youtube.com/watch?v=EXeTwQWrcwY" },
                    { 4, "A hobbit embarks on a journey to destroy a powerful ring.", "https://www.themoviedb.org/t/p/original/6oom5QYQ2yQTMJIbnvbkBL9cHo6.jpg", "The Lord of the Rings: The Fellowship of the Ring", "https://www.youtube.com/watch?v=V75dMMIW2B4" },
                    { 5, "A hacker discovers that the world is a simulation.", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qK76PKQLd6zlMn0u83Ej9YQOqPL.jpg", "The Matrix", "https://www.youtube.com/watch?v=m8e-FF8MsqU" },
                    { 6, "Various interconnected stories of criminals, lowlifes, and a mysterious briefcase.", "https://www.themoviedb.org/t/p/w1280/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg", "Pulp Fiction", "https://www.youtube.com/watch?v=s7EdQ4FqbhY" },
                    { 7, "A freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6UjfRbaSdpNeaJvLIPTdhCO6yzJ.jpg", "Django Unchained", "https://www.youtube.com/watch?v=_iH0UBYDI4g" }
                });

            migrationBuilder.InsertData(
                table: "GenreMovie",
                columns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 11, 1 },
                    { 11, 2 },
                    { 12, 2 },
                    { 1, 3 },
                    { 12, 3 },
                    { 6, 4 },
                    { 11, 5 },
                    { 4, 6 },
                    { 12, 6 },
                    { 13, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_GenresIdGenre",
                table: "GenreMovie",
                column: "GenresIdGenre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GenreMovie",
                table: "GenreMovie");

            migrationBuilder.DropIndex(
                name: "IX_GenreMovie_GenresIdGenre",
                table: "GenreMovie");

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumns: new[] { "GenresIdGenre", "MoviesIdMovie" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 7);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenreMovie",
                table: "GenreMovie",
                columns: new[] { "GenresIdGenre", "MoviesIdMovie" });

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesIdMovie",
                table: "GenreMovie",
                column: "MoviesIdMovie");
        }
    }
}
