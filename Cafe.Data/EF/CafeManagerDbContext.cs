using Cafe.Data.Configurations;
using Cafe.Data.Entities;
using Cafe.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.EF
{
    public class CafeManagerDbContext : DbContext
    {
        public CafeManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        //dùng để configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SellBillConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new StockBillConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInSellBillConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierInStockBillConfiguration());

            modelBuilder.Seed();
        }


        //DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<SellBill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StockBill> StockBills { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductInSellBill> ProductInSellBills { get; set; }
        public DbSet<SupplierInStockBill> SupplierInStockBills { get; set; }

    }
}
