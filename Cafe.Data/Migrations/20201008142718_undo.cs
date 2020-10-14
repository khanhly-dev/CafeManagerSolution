using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafe.Data.Migrations
{
    public partial class undo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserCreated",
                table: "SellBill",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserCreated",
                table: "SellBill",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0356751687",
                column: "DOB",
                value: new DateTime(2020, 10, 8, 21, 25, 30, 248, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0866162243",
                column: "DOB",
                value: new DateTime(2020, 10, 8, 21, 25, 30, 248, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 245, DateTimeKind.Local).AddTicks(3994), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1696), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1722), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1725), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1726), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1727), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1729), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1730), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1731), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1733), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1734), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1735), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1737), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 25, 30, 246, DateTimeKind.Local).AddTicks(1738), 15000 });

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB001",
                column: "DateCreated",
                value: new DateTime(2020, 10, 8, 21, 25, 30, 248, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB002",
                column: "DateCreated",
                value: new DateTime(2020, 10, 8, 21, 25, 30, 248, DateTimeKind.Local).AddTicks(5116));
        }
    }
}
