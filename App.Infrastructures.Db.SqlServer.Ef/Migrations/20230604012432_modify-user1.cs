using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class modifyuser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2a7383-1457-44cc-8639-30625d91d88a", new DateTime(2023, 6, 4, 4, 54, 32, 531, DateTimeKind.Local).AddTicks(1005), "AQAAAAIAAYagAAAAEDdc0ip32fLvIysBfsC8gS48ReRcCrVGE2mcxRRb2UsViZL71vVdm91uaCBqgggQlA==", "54e8dfb5-8700-4936-a2cd-4b0369afa909" });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 4, 54, 32, 613, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 4, 54, 32, 613, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 4, 54, 32, 613, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 4, 54, 32, 613, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 4, 54, 32, 613, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 4, 54, 32, 613, DateTimeKind.Local).AddTicks(3487));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54e8dfb5-8700-4936-a2cd-4b0369afa909", new DateTime(2023, 6, 4, 3, 26, 35, 480, DateTimeKind.Local).AddTicks(425), "AQAAAAIAAYagAAAAEPNQBpPc+hBWMEWr7A+JDgCPSLERQ26XfmIkOwMslgTLkV+ruPRAijaQcLa5/PL7UA==", null });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 26, 35, 562, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 26, 35, 562, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 26, 35, 562, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 26, 35, 562, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 26, 35, 562, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 3, 26, 35, 562, DateTimeKind.Local).AddTicks(598));
        }
    }
}
