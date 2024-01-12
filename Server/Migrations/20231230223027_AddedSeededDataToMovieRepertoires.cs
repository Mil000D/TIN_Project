using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededDataToMovieRepertoires : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieRepertoires_Movies_MovieIdMovie",
                table: "MovieRepertoires");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRepertoires_Repertoires_RepertoireIdRepertoire",
                table: "MovieRepertoires");

            migrationBuilder.DropIndex(
                name: "IX_MovieRepertoires_MovieIdMovie",
                table: "MovieRepertoires");

            migrationBuilder.DropIndex(
                name: "IX_MovieRepertoires_RepertoireIdRepertoire",
                table: "MovieRepertoires");

            migrationBuilder.DropColumn(
                name: "MovieIdMovie",
                table: "MovieRepertoires");

            migrationBuilder.DropColumn(
                name: "RepertoireIdRepertoire",
                table: "MovieRepertoires");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRepertoires_IdMovie",
                table: "MovieRepertoires",
                column: "IdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRepertoires_IdRepertoire",
                table: "MovieRepertoires",
                column: "IdRepertoire");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRepertoires_Movies_IdMovie",
                table: "MovieRepertoires",
                column: "IdMovie",
                principalTable: "Movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRepertoires_Repertoires_IdRepertoire",
                table: "MovieRepertoires",
                column: "IdRepertoire",
                principalTable: "Repertoires",
                principalColumn: "IdRepertoire",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieRepertoires_Movies_IdMovie",
                table: "MovieRepertoires");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRepertoires_Repertoires_IdRepertoire",
                table: "MovieRepertoires");

            migrationBuilder.DropIndex(
                name: "IX_MovieRepertoires_IdMovie",
                table: "MovieRepertoires");

            migrationBuilder.DropIndex(
                name: "IX_MovieRepertoires_IdRepertoire",
                table: "MovieRepertoires");

            migrationBuilder.AddColumn<int>(
                name: "MovieIdMovie",
                table: "MovieRepertoires",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RepertoireIdRepertoire",
                table: "MovieRepertoires",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovieRepertoires_MovieIdMovie",
                table: "MovieRepertoires",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRepertoires_RepertoireIdRepertoire",
                table: "MovieRepertoires",
                column: "RepertoireIdRepertoire");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRepertoires_Movies_MovieIdMovie",
                table: "MovieRepertoires",
                column: "MovieIdMovie",
                principalTable: "Movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRepertoires_Repertoires_RepertoireIdRepertoire",
                table: "MovieRepertoires",
                column: "RepertoireIdRepertoire",
                principalTable: "Repertoires",
                principalColumn: "IdRepertoire",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
