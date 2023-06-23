using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructures.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class relationauctionstore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Sellers",
                table: "Auctions");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "Auctions",
                newName: "StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Auctions_SellerId",
                table: "Auctions",
                newName: "IX_Auctions_StoreId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "83c8b995-cb95-478a-80b9-c7c9eedacc49", new DateTime(2023, 6, 23, 20, 58, 13, 766, DateTimeKind.Local).AddTicks(6631), "AQAAAAIAAYagAAAAEBs620cOEid9aKUmzeJQo+Mus31nquIbdvxeIX35DkRXZHW8S5YPf8sctmsZVvgaPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "27d721a8-3b28-4f3c-923b-af48758411d9", new DateTime(2023, 6, 23, 20, 58, 13, 895, DateTimeKind.Local).AddTicks(7571), "AQAAAAIAAYagAAAAEN+lPf0fSp7SoWQZh+fWUKWC6kPyA4bygs5e/Y7r2e6w2i+Z9LbU+sgJ2/vzhTiSPg==" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3779), new DateTime(2023, 6, 23, 21, 58, 13, 988, DateTimeKind.Local).AddTicks(3759), new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 20, 58, 13, 988, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Stores",
                table: "Auctions",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Stores",
                table: "Auctions");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Auctions",
                newName: "SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Auctions_StoreId",
                table: "Auctions",
                newName: "IX_Auctions_SellerId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "b388e327-eb6b-4e6c-aa61-62cb693d095e", new DateTime(2023, 6, 23, 4, 19, 43, 8, DateTimeKind.Local).AddTicks(4077), "AQAAAAIAAYagAAAAEHtjshWa2pAUQQMU0IjNqqgDE6+W2k1cS1LI62V0/sIlLkcfmAZwSw0r02iNCyBBQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash" },
                values: new object[] { "7ce65d54-5c2b-4b0b-8d60-40c86157b218", new DateTime(2023, 6, 23, 4, 19, 43, 146, DateTimeKind.Local).AddTicks(8167), "AQAAAAIAAYagAAAAEKiQwbyURG7ClqP9LECrE8fWte0j3NebIPAYUheWc/vOEzFaZuFzHRTJz0hqeCZDWg==" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 6, 23, 5, 19, 43, 248, DateTimeKind.Local).AddTicks(5707), new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 4, 19, 43, 248, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Sellers",
                table: "Auctions",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id");
        }
    }
}
