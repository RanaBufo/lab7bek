using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeowLab.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "Birthday", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(1992, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", "Green" },
                    { 2, 25, new DateTime(1997, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kira", "Fox" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
