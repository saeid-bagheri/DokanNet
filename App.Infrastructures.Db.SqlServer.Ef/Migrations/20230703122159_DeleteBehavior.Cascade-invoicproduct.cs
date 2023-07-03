using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class DeleteBehaviorCascadeinvoicproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceProduct_Invoices",
                table: "InvoiceProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceProduct_Products",
                table: "InvoiceProduct");

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

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceProduct_Invoices",
                table: "InvoiceProduct",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceProduct_Products",
                table: "InvoiceProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceProduct_Invoices",
                table: "InvoiceProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceProduct_Products",
                table: "InvoiceProduct");

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

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceProduct_Invoices",
                table: "InvoiceProduct",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceProduct_Products",
                table: "InvoiceProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
