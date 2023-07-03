using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class invoicedeletedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Invoices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "6888c2b3-f64b-4d9d-b140-308cfa38243a", new DateTime(2023, 7, 3, 17, 5, 52, 947, DateTimeKind.Local).AddTicks(8740), "AQAAAAIAAYagAAAAEKNaLL3ihY1TXVZZjGvM0HAuWZm+XqQ8hpm0uqp/4eDmYh/I9mYiNRLD4P+uN7VhIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "30ebb6be-f950-47f0-b661-0d78826aaf7b", new DateTime(2023, 7, 3, 17, 5, 53, 34, DateTimeKind.Local).AddTicks(4402), "AQAAAAIAAYagAAAAEFvxNSkzOTKu14c62kY6ARSlfNPHjrAYHg/2hAwTQmzAwK+/Tj0OgsYSlLT6up4xzA==" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4783), new DateTime(2023, 7, 3, 18, 5, 53, 150, DateTimeKind.Local).AddTicks(4776), new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 7, 53, 150, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4730), null });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4733), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 17, 5, 53, 150, DateTimeKind.Local).AddTicks(4647));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Invoices");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "3c5e148a-c611-4a8e-a800-300f86af3b9c", new DateTime(2023, 7, 3, 16, 56, 13, 472, DateTimeKind.Local).AddTicks(4410), "AQAAAAIAAYagAAAAEFcq2uhmKiXsApVpxyxb72nJAt1kLRIhD4BMEnYQy1ATPEtLAZADk7gvkehGILJrJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "04d8df0a-8e73-4b54-a6f6-14d4e943c24b", new DateTime(2023, 7, 3, 16, 56, 13, 581, DateTimeKind.Local).AddTicks(3752), "AQAAAAIAAYagAAAAECUBptlCn8K1TVpKWJot/DKgieXo0BG/0u/gEHe6WWVlQk25NR8UGDU80TfMeNiItA==" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7689), new DateTime(2023, 7, 3, 17, 56, 13, 718, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 58, 13, 718, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7390));
        }
    }
}
