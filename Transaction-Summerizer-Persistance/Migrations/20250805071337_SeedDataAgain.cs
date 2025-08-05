using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transaction_Summerizer_Persistance.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryDTO",
                columns: new[] { "ID", "Name", "Type" },
                values: new object[] { 1, 0, "Expense" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CategoryID", "Name", "TimeStamp", "TotalSpent" },
                values: new object[] { 1, 1, "Chathuni", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryDTO",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
