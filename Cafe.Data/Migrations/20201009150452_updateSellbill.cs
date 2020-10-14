using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafe.Data.Migrations
{
    public partial class updateSellbill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "SellBill",
                nullable: true,
                defaultValue: "Khách lẻ",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "SellBill",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "Khách lẻ");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0356751687",
                column: "DOB",
                value: new DateTime(2020, 10, 8, 21, 27, 17, 997, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0866162243",
                column: "DOB",
                value: new DateTime(2020, 10, 8, 21, 27, 17, 998, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(614), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8835), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8873), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8875), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8877), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8967), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8969), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8970), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8972), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8973), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8975), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8977), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8979), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 27, 17, 995, DateTimeKind.Local).AddTicks(8980), 15000 });

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB001",
                column: "DateCreated",
                value: new DateTime(2020, 10, 8, 21, 27, 17, 998, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB002",
                column: "DateCreated",
                value: new DateTime(2020, 10, 8, 21, 27, 17, 998, DateTimeKind.Local).AddTicks(2838));
        }
    }
}
