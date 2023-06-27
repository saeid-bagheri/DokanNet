using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class removefeePercentage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeePercentage",
                table: "Sellers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "f9ea5df6-ed44-42e4-9b70-df98e0f5ea86", new DateTime(2023, 6, 27, 4, 9, 13, 525, DateTimeKind.Local).AddTicks(9744), "AQAAAAIAAYagAAAAEBogZfCIvJA/sFh3L0UDSL2FOQtyrBM0Dk0BNxHRHVUz0EGS9KLeHUKa4RMmf7sLWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "27797f78-8191-4211-ba5e-2c636811775e", new DateTime(2023, 6, 27, 4, 9, 13, 618, DateTimeKind.Local).AddTicks(9874), "AQAAAAIAAYagAAAAEO5MGm3SoF4cU5y/WWxQ4qT3UJeo9UHTKcUXI87879/w6f+CMdi5/GGi0QuUzwnfPg==" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 6, 27, 5, 9, 13, 756, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 11, 13, 756, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 27, 4, 9, 13, 756, DateTimeKind.Local).AddTicks(5577));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FeePercentage",
                table: "Sellers",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 25, 1, 37, 57, 217, DateTimeKind.Local).AddTicks(3268));

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
                columns: new[] { "CreatedAt", "FeePercentage" },
                values: new object[] { new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2282), 5m });

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FeePercentage" },
                values: new object[] { new DateTime(2023, 6, 25, 1, 35, 57, 217, DateTimeKind.Local).AddTicks(2339), 5m });

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
    }
}
