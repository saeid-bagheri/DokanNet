using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class categoryimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "7d31761a-01d6-4624-ba9d-021838f083eb", new DateTime(2023, 6, 21, 4, 18, 19, 986, DateTimeKind.Local).AddTicks(6155), "AQAAAAIAAYagAAAAECl1Jy7deruzzg4dgVOPSCHKGrP8+0S6EXyhPXKOMKQqoRBs+3Thoq9Xwme9QF5o4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "dfdd90d2-e868-4739-a50f-1f723edbf750", new DateTime(2023, 6, 21, 4, 18, 20, 63, DateTimeKind.Local).AddTicks(5037), "AQAAAAIAAYagAAAAEO1k2W0mWxz6tHgL+pPCYYehsL6X5E6UU2bXNgUHKNfLktUn5ZZ34AcAL4tRcKjSKg==" });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6846), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6860), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6862), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6864), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6866), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6867), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6869), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 21, 4, 18, 20, 141, DateTimeKind.Local).AddTicks(7058));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");

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
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "683c4cfd-4d67-4728-8095-03756655e390", new DateTime(2023, 6, 21, 1, 25, 33, 614, DateTimeKind.Local).AddTicks(2199), "AQAAAAIAAYagAAAAENRz0IIVutabjTQkq5DSXNCDjGxGOE2evRbtSQg3EqL6Tmhjozmk2htI04F4ZjhpiA==" });

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
    }
}
