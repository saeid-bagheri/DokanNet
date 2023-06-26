using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class seedDatabid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "39f9af85-70cd-4b9e-8480-7f65aecdb90f", new DateTime(2023, 6, 25, 1, 35, 57, 27, DateTimeKind.Local).AddTicks(5376), "AQAAAAIAAYagAAAAEKMZtCvOns16CwLJTaMCALzEGx/We5ITCYbmrviFiTzg/c70cOfAQgCgDiHVePUXkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "672edc3d-da55-4c63-ac0f-ed5023d973e9", new DateTime(2023, 6, 25, 1, 35, 57, 128, DateTimeKind.Local).AddTicks(6438), "AQAAAAIAAYagAAAAEH5s8HsO+cZ3Sq54ErvYbdco2TkaQgOk+zk8p9ptJPc4ksG56Pp+elhyZGplWvLZmg==" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 6, 25, 2, 35, 57, 217, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.InsertData(
                table: "Bids",
                columns: new[] { "Id", "AuctionId", "BuyerId", "CreatedAt", "IsWinner", "Price" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(3265), false, 210000 },
                    { 2, 1, 2, new DateTime(2023, 6, 25, 1, 37, 57, 217, DateTimeKind.Local).AddTicks(3268), true, 220000 }
                });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2640));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "ca0a438f-084f-41a1-aab2-7dfdb76866cd", new DateTime(2023, 6, 23, 21, 14, 31, 60, DateTimeKind.Local).AddTicks(2957), "AQAAAAIAAYagAAAAEOl8jbzBwvuyhe8OgbAVIkAemHBFHL0Kq8fqX2IxDDnQXTfDIu2uo1ZWqt6cIb8PEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "14ff62a8-8b89-4e4b-a2f7-daad93db8712", new DateTime(2023, 6, 23, 21, 14, 31, 139, DateTimeKind.Local).AddTicks(8627), "AQAAAAIAAYagAAAAEI6vOrU4x4g4cv5VdHa+wG/h+EMiusNZv2iJ0uYFCV1T08+2uImxvaIkci0W2tV+fg==" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9866), new DateTime(2023, 6, 23, 22, 14, 31, 218, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9728));
        }
    }
}
