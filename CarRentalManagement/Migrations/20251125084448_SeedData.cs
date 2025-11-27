using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(4832), new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(4843), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(4844), new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(4845), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(4989), new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(4990), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(4991), new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(4992), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(5049), new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(5050), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(5051), new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(5052), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(5053), new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(5053), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(5054), new DateTime(2025, 11, 25, 16, 44, 47, 770, DateTimeKind.Local).AddTicks(5055), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
