using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TIN_Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedDataToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "BirthDate", "Email", "Name", "Password", "RefreshToken", "RefreshTokenExpirationDate", "Role", "Surname", "Username" },
                values: new object[] { 1, new DateOnly(1999, 1, 1), "wowowow", "John", "password", null, null, 1, "Doe", "username" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1);
        }
    }
}
