using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafe.Data.Migrations
{
    public partial class editSellBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pay",
                table: "SellBill",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PayBack",
                table: "SellBill",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0356751687",
                column: "DOB",
                value: new DateTime(2020, 10, 9, 22, 35, 49, 898, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0866162243",
                column: "DOB",
                value: new DateTime(2020, 10, 9, 22, 35, 49, 898, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 895, DateTimeKind.Local).AddTicks(4683), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2340), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2371), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2373), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2374), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2376), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2377), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2379), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2380), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2382), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2383), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2384), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2385), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2426), 15000 });

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB001",
                columns: new[] { "CustomerId", "DateCreated" },
                values: new object[] { "0356751687", new DateTime(2020, 10, 9, 22, 35, 49, 898, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB002",
                columns: new[] { "CustomerId", "DateCreated" },
                values: new object[] { "0356751687", new DateTime(2020, 10, 9, 22, 35, 49, 898, DateTimeKind.Local).AddTicks(5159) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pay",
                table: "SellBill");

            migrationBuilder.DropColumn(
                name: "PayBack",
                table: "SellBill");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0356751687",
                column: "DOB",
                value: new DateTime(2020, 10, 9, 22, 4, 52, 450, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0866162243",
                column: "DOB",
                value: new DateTime(2020, 10, 9, 22, 4, 52, 451, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(360), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8169), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8194), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8197), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8198), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8199), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8201), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8202), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8203), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8205), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8207), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8208), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8209), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 9, 22, 4, 52, 448, DateTimeKind.Local).AddTicks(8211), 15000 });

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB001",
                columns: new[] { "CustomerId", "DateCreated" },
                values: new object[] { "0356751687", new DateTime(2020, 10, 9, 22, 4, 52, 450, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB002",
                columns: new[] { "CustomerId", "DateCreated" },
                values: new object[] { "0356751687", new DateTime(2020, 10, 9, 22, 4, 52, 451, DateTimeKind.Local).AddTicks(786) });
        }
    }
}
