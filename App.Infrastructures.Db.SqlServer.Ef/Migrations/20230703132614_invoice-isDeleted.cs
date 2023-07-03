using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class invoiceisDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Invoices",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7615), false });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 7, 3, 16, 56, 13, 718, DateTimeKind.Local).AddTicks(7617), false });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Invoices");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "af9c53ba-66c5-47f2-b701-9d7e4b07574d", new DateTime(2023, 7, 3, 15, 51, 58, 312, DateTimeKind.Local).AddTicks(1629), "AQAAAAIAAYagAAAAECnY7QORr3VEb+c+Ni6KbPwG7/GMBTLRY1yuFdwcYyrBSAvJ62dvQKZQMjLKBQCl9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e146ee1b-bc08-4acd-953d-fb6c65e4fcaa", new DateTime(2023, 7, 3, 15, 51, 58, 442, DateTimeKind.Local).AddTicks(7200), "AQAAAAIAAYagAAAAEDKGc6a4UtNNEQ0vse4sEReUlDjMqHrXS1b5wuln8aQVyeAucAOnYmGw4oKrC6Bopg==" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(9259), new DateTime(2023, 7, 3, 16, 51, 58, 549, DateTimeKind.Local).AddTicks(9249), new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 53, 58, 549, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 3, 15, 51, 58, 549, DateTimeKind.Local).AddTicks(8918));
        }
    }
}
