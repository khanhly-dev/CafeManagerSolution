using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafe.Data.Migrations
{
    public partial class addBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0356751687",
                column: "DOB",
                value: new DateTime(2020, 9, 14, 10, 42, 15, 978, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0866162243",
                column: "DOB",
                value: new DateTime(2020, 9, 14, 10, 42, 15, 979, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 975, DateTimeKind.Local).AddTicks(5559), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6624), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6671), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6674), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6675), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6677), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6679), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6682), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6684), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6686), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6687), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6689), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6690), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 14, 10, 42, 15, 976, DateTimeKind.Local).AddTicks(6691), 15000 });

            migrationBuilder.InsertData(
                table: "ProductInSellBill",
                columns: new[] { "SellBillId", "ProductId" },
                values: new object[,]
                {
                    { "HDB002", 7 },
                    { "HDB002", 6 },
                    { "HDB002", 1 }
                });

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB001",
                column: "DateCreated",
                value: new DateTime(2020, 9, 14, 10, 42, 15, 978, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB002",
                column: "DateCreated",
                value: new DateTime(2020, 9, 14, 10, 42, 15, 979, DateTimeKind.Local).AddTicks(519));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInSellBill",
                keyColumns: new[] { "SellBillId", "ProductId" },
                keyValues: new object[] { "HDB002", 1 });

            migrationBuilder.DeleteData(
                table: "ProductInSellBill",
                keyColumns: new[] { "SellBillId", "ProductId" },
                keyValues: new object[] { "HDB002", 6 });

            migrationBuilder.DeleteData(
                table: "ProductInSellBill",
                keyColumns: new[] { "SellBillId", "ProductId" },
                keyValues: new object[] { "HDB002", 7 });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0356751687",
                column: "DOB",
                value: new DateTime(2020, 9, 7, 22, 24, 43, 67, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: "0866162243",
                column: "DOB",
                value: new DateTime(2020, 9, 7, 22, 24, 43, 67, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 63, DateTimeKind.Local).AddTicks(7888), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(535), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(587), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(589), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(591), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(592), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(593), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(597), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(599), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(601), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(602), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(606), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(609), 15000 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(610), 15000 });

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB001",
                column: "DateCreated",
                value: new DateTime(2020, 9, 7, 22, 24, 43, 67, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "SellBill",
                keyColumn: "Id",
                keyValue: "HDB002",
                column: "DateCreated",
                value: new DateTime(2020, 9, 7, 22, 24, 43, 67, DateTimeKind.Local).AddTicks(6719));
        }
    }
}
