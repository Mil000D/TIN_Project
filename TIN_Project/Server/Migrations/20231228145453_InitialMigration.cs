using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    IdCinema = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.IdCinema);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Login = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    IdGenre = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.IdGenre);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    IdMovie = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    TrailerUrl = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PosterUrl = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.IdMovie);
                });

            migrationBuilder.CreateTable(
                name: "Repertoires",
                columns: table => new
                {
                    IdRepertoire = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Day = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    IdCinema = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repertoires", x => x.IdRepertoire);
                    table.ForeignKey(
                        name: "FK_Repertoires_Cinemas_IdCinema",
                        column: x => x.IdCinema,
                        principalTable: "Cinemas",
                        principalColumn: "IdCinema",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresIdGenre = table.Column<int>(type: "INTEGER", nullable: false),
                    MoviesIdMovie = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresIdGenre, x.MoviesIdMovie });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenresIdGenre",
                        column: x => x.GenresIdGenre,
                        principalTable: "Genres",
                        principalColumn: "IdGenre",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_MoviesIdMovie",
                        column: x => x.MoviesIdMovie,
                        principalTable: "Movies",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieRepertoires",
                columns: table => new
                {
                    IdMovieRepertoire = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdMovie = table.Column<int>(type: "INTEGER", nullable: false),
                    MovieIdMovie = table.Column<int>(type: "INTEGER", nullable: false),
                    IdRepertoire = table.Column<int>(type: "INTEGER", nullable: false),
                    RepertoireIdRepertoire = table.Column<int>(type: "INTEGER", nullable: false),
                    ShowTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRepertoires", x => x.IdMovieRepertoire);
                    table.ForeignKey(
                        name: "FK_MovieRepertoires_Movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "Movies",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieRepertoires_Repertoires_RepertoireIdRepertoire",
                        column: x => x.RepertoireIdRepertoire,
                        principalTable: "Repertoires",
                        principalColumn: "IdRepertoire",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false),
                    IdMovieRepertoire = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfPayment = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => new { x.IdUser, x.IdMovieRepertoire });
                    table.ForeignKey(
                        name: "FK_Orders_Customers_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Customers",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_MovieRepertoires_IdMovieRepertoire",
                        column: x => x.IdMovieRepertoire,
                        principalTable: "MovieRepertoires",
                        principalColumn: "IdMovieRepertoire",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesIdMovie",
                table: "GenreMovie",
                column: "MoviesIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRepertoires_MovieIdMovie",
                table: "MovieRepertoires",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRepertoires_RepertoireIdRepertoire",
                table: "MovieRepertoires",
                column: "RepertoireIdRepertoire");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdMovieRepertoire",
                table: "Orders",
                column: "IdMovieRepertoire");

            migrationBuilder.CreateIndex(
                name: "IX_Repertoires_IdCinema",
                table: "Repertoires",
                column: "IdCinema");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MovieRepertoires");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Repertoires");

            migrationBuilder.DropTable(
                name: "Cinemas");
        }
    }
}
