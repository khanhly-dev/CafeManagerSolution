using Cafe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Sg Cafe", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated="admin"},
                new Product() { Id = 2, Name = "Sg Cafe Milk", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 3, Name = "Espresso(Cafe nóng)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 4, Name = "Cappuccino(Cafe Ý)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 5, Name = "Latte(Cafe tạo hình)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 6, Name = "Coolies'N Cream(Cafe Cookies)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 7, Name = "Blende Coffee Balley(Cafe rượu sữa)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 8, Name = "Kiwi(sinh tố kiwi)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 9, Name = "Strawberry(Dâu)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 10, Name = "Blubery(Việt quất)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 11, Name = "Lychee(Vải)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 12, Name = "Peach(Đào)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 13, Name = "Green Tea(Trà xanh)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" },
                new Product() { Id = 14, Name = "Soda Grapefruit(Soda bưởi)", Price = 15000, Description = "Đồ uống", DateCreated = DateTime.Now, UserCreated = "admin" }
                );

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, RoleId = 1, UserName = "admin", Password = "admin" },
                new User() { Id = 2, RoleId = 2, UserName = "cashier", Password = "1" },
                new User() { Id = 3, RoleId = 3, UserName = "stocker", Password = "1" }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = 1,
                    Description = "Admin",
                    IsShowSell = true,
                    IsShowProduct = true,
                    IsShowSupplier = true,
                    IsShowCustomer = true,
                    IsShowSellBill = true,
                    IsShowEmployee = true,
                    IsShowRevenue = true,
                    IsShowTranfers = true,
                    IsShowStockBill = true
                },

                new Role()
                {
                    Id = 2,
                    Description = "Cashier",
                    IsShowSell = true,
                    IsShowProduct = true,
                    IsShowSupplier = false,
                    IsShowCustomer = true,
                    IsShowSellBill = true,
                    IsShowStockBill = false,
                    IsShowEmployee = false,
                    IsShowRevenue = false,
                    IsShowTranfers = false
                },

                new Role()
                {
                    Id = 3,
                    Description = "Stocker",
                    IsShowSell = false,
                    IsShowProduct = true,
                    IsShowSupplier = false,
                    IsShowCustomer = false,
                    IsShowSellBill = false,
                    IsShowStockBill = true,
                    IsShowEmployee = false,
                    IsShowRevenue = false,
                    IsShowTranfers = true
                }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = "0356751687",
                    Name = "leduykhanh",
                    PhoneNumber =  "0356751687",
                    Adress= "lamdien",
                    Sex = true,
                    DOB = DateTime.Now
                }
                );


            modelBuilder.Entity<SellBill>().HasData(
                new SellBill
                {
                    Id = "HDB001",
                    CustomerId = "0356751687",
                    DateCreated = DateTime.Now,
                    UserCreated = "admin",
                    OriginalPrice = 15000,
                    Discout = 0,
                    TotalPrice = 30000
                },
                new SellBill
                {
                    Id = "HDB002",
                    CustomerId = "0356751687",
                    DateCreated = DateTime.Now,
                    UserCreated = "admin",
                    OriginalPrice = 20000,
                    Discout = 0,
                    TotalPrice = 20000
                }
                );

            modelBuilder.Entity<ProductInSellBill>().HasData(
                new ProductInSellBill
                {
                    SellBillId = "HDB001",
                    ProductId = 1
                },
                new ProductInSellBill
                {
                    SellBillId = "HDB001",
                    ProductId = 2
                },
                new ProductInSellBill
                {
                    SellBillId = "HDB001",
                    ProductId = 5
                }
                );

            modelBuilder.Entity<ProductInSellBill>().HasData(
                new ProductInSellBill
                {
                    SellBillId = "HDB002",
                    ProductId = 1
                },
                new ProductInSellBill
                {
                    SellBillId = "HDB002",
                    ProductId = 6
                },
                new ProductInSellBill
                {
                    SellBillId = "HDB002",
                    ProductId = 7
                }
                );

            modelBuilder.Entity<Customer>().HasData(
               new Customer
               {
                   Id = "0866162243",
                   Name = "nguyenvana",
                   PhoneNumber = "0866162243",
                   Adress = "lamdien",
                   Sex = true,
                   DOB = DateTime.Now
               }
               );
        }
    }
}
