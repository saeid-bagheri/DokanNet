using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class cityIdnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Buyers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "3db6e92f-a55e-4fc5-beb3-ef2faf44ac32", new DateTime(2023, 6, 4, 5, 27, 34, 521, DateTimeKind.Local).AddTicks(7209), "AQAAAAIAAYagAAAAEOB5KI2Gt6/0w1HIz/DWW8XFK/qtoO5vCq6MewFcm7vOkvXZ3lNYqJlJN5UBVEV3mw==" });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 5, 27, 34, 644, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 5, 27, 34, 644, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 5, 27, 34, 644, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 5, 27, 34, 644, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 5, 27, 34, 644, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 4, 5, 27, 34, 644, DateTimeKind.Local).AddTicks(9798));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Buyers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "5a2a7383-1457-44cc-8639-30625d91d88a", new DateTime(2023, 6, 4, 4, 54, 32, 531, DateTimeKind.Local).AddTicks(1005), "AQAAAAIAAYagAAAAEDdc0ip32fLvIysBfsC8gS48ReRcCrVGE2mcxRRb2UsViZL71vVdm91uaCBqgggQlA==" });

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
    }
}
