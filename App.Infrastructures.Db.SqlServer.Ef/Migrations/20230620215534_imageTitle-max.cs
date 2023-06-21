using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class imageTitlemax : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "aeead101-98a6-4d00-8ff1-8c952601f0c4", new DateTime(2023, 6, 21, 1, 25, 33, 482, DateTimeKind.Local).AddTicks(2622), "AQAAAAIAAYagAAAAEPYeazzqU+SN46gFPU0cTyAEtQcij28YG6L37/XhfruQJkK8TK+b/4CmFoRWuAccaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "683c4cfd-4d67-4728-8095-03756655e390", new DateTime(2023, 6, 21, 1, 25, 33, 614, DateTimeKind.Local).AddTicks(2199), "AQAAAAIAAYagAAAAENRz0IIVutabjTQkq5DSXNCDjGxGOE2evRbtSQg3EqL6Tmhjozmk2htI04F4ZjhpiA==", "KKNDWQL54F5NAZZM6LOLFGBUYZWSPKVU" });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 1, 25, 33, 729, DateTimeKind.Local).AddTicks(8910));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Images",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "11dab4e8-576d-49d0-9b8c-38f930b4e5cb", new DateTime(2023, 6, 14, 16, 47, 38, 308, DateTimeKind.Local).AddTicks(2152), "AQAAAAIAAYagAAAAEGHY/VU0Ojy4DEKaQdc1ERDtV9vy7UI23NPKrwCkEtvgk7Ry18hRM/FIHOtkqySQdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c261b5ad-8e20-420e-806c-5315f8a77475", new DateTime(2023, 6, 14, 16, 47, 38, 436, DateTimeKind.Local).AddTicks(3833), "AQAAAAIAAYagAAAAEEVZxTRIEkYc3XxZdcDqF5AzriElSlslazfI1k6KEw3CUrG6QPAD6I45+hd88ozfWA==", null });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 556, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 556, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 556, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 556, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 556, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 556, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 556, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 47, 38, 557, DateTimeKind.Local).AddTicks(574));
        }
    }
}
