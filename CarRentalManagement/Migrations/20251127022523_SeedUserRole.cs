using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "38f10a15-d721-4093-942a-abbd714a344c", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEP/z07paP6bkT0OeLXmwxUKnFhTWpEhUp/jlaDUW86bekDuh1+uUJL9o9WgRMeqNJg==", null, false, "70c5ed70-e816-4dc6-9bc6-ded4b15b47ca", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3653), new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3665), new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3816), new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3818), new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3885), new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3888), new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3889), new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3891), new DateTime(2025, 11, 27, 10, 25, 22, 772, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(7485), new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(7510), new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(7921), new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(7927), new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(8095), new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(8101), new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(8105), new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(8110), new DateTime(2025, 11, 27, 9, 55, 25, 423, DateTimeKind.Local).AddTicks(8111) });
        }
    }
}
