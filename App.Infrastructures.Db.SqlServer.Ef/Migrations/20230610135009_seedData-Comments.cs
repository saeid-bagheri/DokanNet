using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class seedDataComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BuyerId", "CreatedAt", "DeletedAt", "Description", "IsConfirmed", "IsDeleted", "ProductId", "Score" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4315), null, "راضی بودم خوب بود.", false, false, 1, 4 },
                    { 2, 1, new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4318), null, "جنسش بی کیفیت بود.", false, false, 2, 2 },
                    { 3, 2, new DateTime(2023, 6, 10, 17, 20, 8, 748, DateTimeKind.Local).AddTicks(4321), null, "قیمتش خیلی بالاست", false, false, 5, 4 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "0699177b-fadc-4b59-8a63-e3cf520e493f", new DateTime(2023, 6, 6, 1, 25, 21, 500, DateTimeKind.Local).AddTicks(4890), "AQAAAAIAAYagAAAAEAgL2pkEGeG7bHFMWZhfYpBv94RgYgNsnQrnnz+4COvT1eS0lxoxV8BI2McXV61EuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "1fb6ea3f-34a4-470e-8af2-ba879c61cc23", new DateTime(2023, 6, 6, 1, 25, 21, 587, DateTimeKind.Local).AddTicks(2073), "AQAAAAIAAYagAAAAEHzjQbjxl77EMw3VVVbQmobSPuj4ltgdvk3OqwZ4IEfwmrDFbPGReS1Yg1z/2XKNPQ==" });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 6, 1, 25, 21, 681, DateTimeKind.Local).AddTicks(1972));
        }
    }
}
