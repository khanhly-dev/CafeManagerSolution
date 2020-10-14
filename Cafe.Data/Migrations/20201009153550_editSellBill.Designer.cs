﻿// <auto-generated />
using System;
using Cafe.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cafe.Data.Migrations
{
    [DbContext(typeof(CafeManagerDbContext))]
    [Migration("20201009153550_editSellBill")]
    partial class editSellBill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cafe.Data.Entities.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)")
                        .IsUnicode(true);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .IsUnicode(true);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = "0356751687",
                            Adress = "lamdien",
                            DOB = new DateTime(2020, 10, 9, 22, 35, 49, 898, DateTimeKind.Local).AddTicks(1518),
                            Name = "leduykhanh",
                            PhoneNumber = "0356751687",
                            Sex = true
                        },
                        new
                        {
                            Id = "0866162243",
                            Adress = "lamdien",
                            DOB = new DateTime(2020, 10, 9, 22, 35, 49, 898, DateTimeKind.Local).AddTicks(6670),
                            Name = "nguyenvana",
                            PhoneNumber = "0866162243",
                            Sex = true
                        });
                });

            modelBuilder.Entity("Cafe.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adress")
                        .HasColumnType("int");

                    b.Property<int>("Description")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Cafe.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .IsUnicode(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .IsUnicode(true);

                    b.Property<int>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("UserCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEdited")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 895, DateTimeKind.Local).AddTicks(4683),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Sg Cafe",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2340),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Sg Cafe Milk",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2371),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Espresso(Cafe nóng)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2373),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Cappuccino(Cafe Ý)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2374),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Latte(Cafe tạo hình)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2376),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Coolies'N Cream(Cafe Cookies)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2377),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Blende Coffee Balley(Cafe rượu sữa)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 8,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2379),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Kiwi(sinh tố kiwi)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 9,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2380),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Strawberry(Dâu)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 10,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2382),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Blubery(Việt quất)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 11,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2383),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Lychee(Vải)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 12,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2384),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Peach(Đào)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 13,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2385),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Green Tea(Trà xanh)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = 14,
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 896, DateTimeKind.Local).AddTicks(2426),
                            DateEdited = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồ uống",
                            Name = "Soda Grapefruit(Soda bưởi)",
                            Price = 15000,
                            Quantity = 0,
                            UserCreated = "admin"
                        });
                });

            modelBuilder.Entity("Cafe.Data.Entities.ProductInSellBill", b =>
                {
                    b.Property<string>("SellBillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("SellBillId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInSellBill");

                    b.HasData(
                        new
                        {
                            SellBillId = "HDB001",
                            ProductId = 1
                        },
                        new
                        {
                            SellBillId = "HDB001",
                            ProductId = 2
                        },
                        new
                        {
                            SellBillId = "HDB001",
                            ProductId = 5
                        },
                        new
                        {
                            SellBillId = "HDB002",
                            ProductId = 1
                        },
                        new
                        {
                            SellBillId = "HDB002",
                            ProductId = 6
                        },
                        new
                        {
                            SellBillId = "HDB002",
                            ProductId = 7
                        });
                });

            modelBuilder.Entity("Cafe.Data.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsShowCustomer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowEmployee")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowRevenue")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowSell")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowSellBill")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowStockBill")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowSupplier")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowTranfers")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Admin",
                            IsShowCustomer = true,
                            IsShowEmployee = true,
                            IsShowProduct = true,
                            IsShowRevenue = true,
                            IsShowSell = true,
                            IsShowSellBill = true,
                            IsShowStockBill = true,
                            IsShowSupplier = true,
                            IsShowTranfers = true
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cashier",
                            IsShowCustomer = true,
                            IsShowEmployee = false,
                            IsShowProduct = true,
                            IsShowRevenue = false,
                            IsShowSell = true,
                            IsShowSellBill = true,
                            IsShowStockBill = false,
                            IsShowSupplier = false,
                            IsShowTranfers = false
                        },
                        new
                        {
                            Id = 3,
                            Description = "Stocker",
                            IsShowCustomer = false,
                            IsShowEmployee = false,
                            IsShowProduct = true,
                            IsShowRevenue = false,
                            IsShowSell = false,
                            IsShowSellBill = false,
                            IsShowStockBill = true,
                            IsShowSupplier = false,
                            IsShowTranfers = true
                        });
                });

            modelBuilder.Entity("Cafe.Data.Entities.SellBill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValue("Khách lẻ");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discout")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OriginalPrice")
                        .HasColumnType("int");

                    b.Property<int>("Pay")
                        .HasColumnType("int");

                    b.Property<int>("PayBack")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<string>("UserCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("SellBill");

                    b.HasData(
                        new
                        {
                            Id = "HDB001",
                            CustomerId = "0356751687",
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 898, DateTimeKind.Local).AddTicks(3224),
                            Discout = 0,
                            OriginalPrice = 15000,
                            Pay = 0,
                            PayBack = 0,
                            TotalPrice = 30000,
                            UserCreated = "admin"
                        },
                        new
                        {
                            Id = "HDB002",
                            CustomerId = "0356751687",
                            DateCreated = new DateTime(2020, 10, 9, 22, 35, 49, 898, DateTimeKind.Local).AddTicks(5159),
                            Discout = 0,
                            OriginalPrice = 20000,
                            Pay = 0,
                            PayBack = 0,
                            TotalPrice = 20000,
                            UserCreated = "admin"
                        });
                });

            modelBuilder.Entity("Cafe.Data.Entities.StockBill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Discout")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OriginalPrice")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StockBill");
                });

            modelBuilder.Entity("Cafe.Data.Entities.Supplier", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("Cafe.Data.Entities.SupplierInStockBill", b =>
                {
                    b.Property<string>("SupplierId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StockBillId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SupplierId", "StockBillId");

                    b.HasIndex("StockBillId");

                    b.ToTable("SupplierInStockBill");
                });

            modelBuilder.Entity("Cafe.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin",
                            RoleId = 1,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Password = "1",
                            RoleId = 2,
                            UserName = "cashier"
                        },
                        new
                        {
                            Id = 3,
                            Password = "1",
                            RoleId = 3,
                            UserName = "stocker"
                        });
                });

            modelBuilder.Entity("Cafe.Data.Entities.ProductInSellBill", b =>
                {
                    b.HasOne("Cafe.Data.Entities.Product", "Product")
                        .WithMany("ProductInSellBills")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cafe.Data.Entities.SellBill", "SellBill")
                        .WithMany("ProductInSellBills")
                        .HasForeignKey("SellBillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cafe.Data.Entities.SellBill", b =>
                {
                    b.HasOne("Cafe.Data.Entities.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Cafe.Data.Entities.SupplierInStockBill", b =>
                {
                    b.HasOne("Cafe.Data.Entities.StockBill", "StockBill")
                        .WithMany("SupplierInStockBills")
                        .HasForeignKey("StockBillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cafe.Data.Entities.Supplier", "Supplier")
                        .WithMany("SupplierInStockBills")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cafe.Data.Entities.User", b =>
                {
                    b.HasOne("Cafe.Data.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
