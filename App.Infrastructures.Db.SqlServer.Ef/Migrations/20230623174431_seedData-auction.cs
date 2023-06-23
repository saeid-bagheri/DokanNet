using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class seedDataauction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "Id", "CountOfProducts", "CreatedAt", "EndTime", "HasBuyer", "Price", "ProductId", "StartTime", "StoreId" },
                values: new object[] { 1, 1, new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9866), new DateTime(2023, 6, 23, 22, 14, 31, 218, DateTimeKind.Local).AddTicks(9847), false, 200000, 9, new DateTime(2023, 6, 23, 21, 14, 31, 218, DateTimeKind.Local).AddTicks(9846), 4 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e81319d9-a0a9-43d7-a4f5-d80d6320fbcb", new DateTime(2023, 6, 23, 21, 4, 53, 585, DateTimeKind.Local).AddTicks(597), "AQAAAAIAAYagAAAAEPYUh2EBCq8bpKJLfyC+LaTAXbGnGg1wXQ7IlqJEbKwFZB1pmJSO/MDRPZoKG/DO3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "c47e6b64-9f70-4c1c-bf67-e2ad3f9ce219", new DateTime(2023, 6, 23, 21, 4, 53, 718, DateTimeKind.Local).AddTicks(7910), "AQAAAAIAAYagAAAAECcgb+Eh2GwY66ErCDnEQ5GnjK871E42S+OoMNTicXbZGTVLdd9WGsROwZEcbcuQVg==" });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 21, 4, 53, 820, DateTimeKind.Local).AddTicks(6971));
        }
    }
}
