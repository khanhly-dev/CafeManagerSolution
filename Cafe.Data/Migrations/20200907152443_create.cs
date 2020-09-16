using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafe.Data.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    Sex = table.Column<bool>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<int>(nullable: false),
                    Adress = table.Column<int>(nullable: false),
                    Description = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 1),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false, defaultValue: 0),
                    Description = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateEdited = table.Column<DateTime>(nullable: false),
                    UserEdited = table.Column<string>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    IsShowSell = table.Column<bool>(nullable: false),
                    IsShowProduct = table.Column<bool>(nullable: false),
                    IsShowCustomer = table.Column<bool>(nullable: false),
                    IsShowSupplier = table.Column<bool>(nullable: false),
                    IsShowTranfers = table.Column<bool>(nullable: false),
                    IsShowSellBill = table.Column<bool>(nullable: false),
                    IsShowStockBill = table.Column<bool>(nullable: false),
                    IsShowEmployee = table.Column<bool>(nullable: false),
                    IsShowRevenue = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockBill",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OriginalPrice = table.Column<int>(nullable: false),
                    Discout = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockBill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellBill",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: false),
                    OriginalPrice = table.Column<int>(nullable: false),
                    Discout = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellBill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellBill_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierInStockBill",
                columns: table => new
                {
                    StockBillId = table.Column<string>(nullable: false),
                    SupplierId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierInStockBill", x => new { x.SupplierId, x.StockBillId });
                    table.ForeignKey(
                        name: "FK_SupplierInStockBill_StockBill_StockBillId",
                        column: x => x.StockBillId,
                        principalTable: "StockBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierInStockBill_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInSellBill",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    SellBillId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInSellBill", x => new { x.SellBillId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInSellBill_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInSellBill_SellBill_SellBillId",
                        column: x => x.SellBillId,
                        principalTable: "SellBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Adress", "DOB", "Name", "PhoneNumber", "Sex" },
                values: new object[,]
                {
                    { "0356751687", "lamdien", new DateTime(2020, 9, 7, 22, 24, 43, 67, DateTimeKind.Local).AddTicks(3068), "leduykhanh", "0356751687", true },
                    { "0866162243", "lamdien", new DateTime(2020, 9, 7, 22, 24, 43, 67, DateTimeKind.Local).AddTicks(8318), "nguyenvana", "0866162243", true }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "DateEdited", "Description", "Name", "Price", "UserCreated", "UserEdited" },
                values: new object[,]
                {
                    { 14, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(610), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Soda Grapefruit(Soda bưởi)", 15000, "admin", null },
                    { 13, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(609), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Green Tea(Trà xanh)", 15000, "admin", null },
                    { 12, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(606), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Peach(Đào)", 15000, "admin", null },
                    { 11, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(602), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Lychee(Vải)", 15000, "admin", null },
                    { 10, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(601), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Blubery(Việt quất)", 15000, "admin", null },
                    { 9, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(599), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Strawberry(Dâu)", 15000, "admin", null },
                    { 8, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(597), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Kiwi(sinh tố kiwi)", 15000, "admin", null },
                    { 6, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(592), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Coolies'N Cream(Cafe Cookies)", 15000, "admin", null },
                    { 5, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(591), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Latte(Cafe tạo hình)", 15000, "admin", null },
                    { 4, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(589), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Cappuccino(Cafe Ý)", 15000, "admin", null },
                    { 3, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(587), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Espresso(Cafe nóng)", 15000, "admin", null },
                    { 2, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(535), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Sg Cafe Milk", 15000, "admin", null },
                    { 1, new DateTime(2020, 9, 7, 22, 24, 43, 63, DateTimeKind.Local).AddTicks(7888), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Sg Cafe", 15000, "admin", null },
                    { 7, new DateTime(2020, 9, 7, 22, 24, 43, 65, DateTimeKind.Local).AddTicks(593), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồ uống", "Blende Coffee Balley(Cafe rượu sữa)", 15000, "admin", null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Description", "IsShowCustomer", "IsShowEmployee", "IsShowProduct", "IsShowRevenue", "IsShowSell", "IsShowSellBill", "IsShowStockBill", "IsShowSupplier", "IsShowTranfers" },
                values: new object[,]
                {
                    { 2, "Cashier", true, false, true, false, true, true, false, false, false },
                    { 1, "Admin", true, true, true, true, true, true, true, true, true },
                    { 3, "Stocker", false, false, true, false, false, false, true, false, true }
                });

            migrationBuilder.InsertData(
                table: "SellBill",
                columns: new[] { "Id", "CustomerId", "DateCreated", "Discout", "Note", "OriginalPrice", "TotalPrice", "UserCreated" },
                values: new object[,]
                {
                    { "HDB001", "0356751687", new DateTime(2020, 9, 7, 22, 24, 43, 67, DateTimeKind.Local).AddTicks(4834), 0, null, 15000, 30000, "admin" },
                    { "HDB002", "0356751687", new DateTime(2020, 9, 7, 22, 24, 43, 67, DateTimeKind.Local).AddTicks(6719), 0, null, 20000, 20000, "admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Password", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 1, "admin", 1, "admin" },
                    { 2, "1", 2, "cashier" },
                    { 3, "1", 3, "stocker" }
                });

            migrationBuilder.InsertData(
                table: "ProductInSellBill",
                columns: new[] { "SellBillId", "ProductId" },
                values: new object[] { "HDB001", 1 });

            migrationBuilder.InsertData(
                table: "ProductInSellBill",
                columns: new[] { "SellBillId", "ProductId" },
                values: new object[] { "HDB001", 2 });

            migrationBuilder.InsertData(
                table: "ProductInSellBill",
                columns: new[] { "SellBillId", "ProductId" },
                values: new object[] { "HDB001", 5 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInSellBill_ProductId",
                table: "ProductInSellBill",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SellBill_CustomerId",
                table: "SellBill",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierInStockBill_StockBillId",
                table: "SupplierInStockBill",
                column: "StockBillId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ProductInSellBill");

            migrationBuilder.DropTable(
                name: "SupplierInStockBill");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SellBill");

            migrationBuilder.DropTable(
                name: "StockBill");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
