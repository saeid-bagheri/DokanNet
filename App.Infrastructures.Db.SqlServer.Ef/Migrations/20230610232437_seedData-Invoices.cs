using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class seedDataInvoices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "352b6aab-d433-41d2-bc68-f9b6b3f6ba9e", new DateTime(2023, 6, 11, 2, 54, 36, 17, DateTimeKind.Local).AddTicks(763), "AQAAAAIAAYagAAAAEJKcsF7Lb1E/AJ8BBBjVs/oyCWlfnIVYnhje3sdF+5RsPDZJSnkhftfIZS3GbKRS6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "707fed61-677f-4d92-a65a-c55d096582ba", new DateTime(2023, 6, 11, 2, 54, 36, 152, DateTimeKind.Local).AddTicks(585), "AQAAAAIAAYagAAAAEASUyzZSaM7I/C9G6tsy/JwkRYN/eDHz6fBL8aDP8u/EL8SHR1kQbTjQb11BqYvUBw==" });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "BuyerId", "CreatedAt", "IsFinal", "SellerId", "SiteCommission", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6414), true, 1, 55000, 1100000 },
                    { 2, 2, new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6417), true, 2, 475000, 9500000 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 2, 54, 36, 328, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.InsertData(
                table: "InvoiceProduct",
                columns: new[] { "Id", "CountOfProducts", "InvoiceId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 2 },
                    { 3, 1, 2, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvoiceProduct",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InvoiceProduct",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InvoiceProduct",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "e39be46e-f5ec-47af-bc56-4bb99e08178f", new DateTime(2023, 6, 10, 17, 20, 8, 461, DateTimeKind.Local).AddTicks(3123), "AQAAAAIAAYagAAAAEKgnhTioX5hIND7ScN+QVpRMl0nHof5kA7TtY6rguZxt5eUPVwUozkVHpB9UYr6VCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "3f2a6289-b5af-47cb-9e1d-9be2b8c6933c", new DateTime(2023, 6, 10, 17, 20, 8, 602, DateTimeKind.Local).AddTicks(8287), "AQAAAAIAAYagAAAAEO5C2ISusCd4osiuRh7151dcxT9Sp12QZzAuhiMkj5TerTyXBUnrFrlFEgiDJjc8rA==" });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4287));
        }
    }
}
