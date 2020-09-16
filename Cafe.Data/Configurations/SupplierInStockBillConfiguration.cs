using Cafe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cafe.Data.Configurations
{
    public class SupplierInStockBillConfiguration : IEntityTypeConfiguration<SupplierInStockBill>
    {
        public void Configure(EntityTypeBuilder<SupplierInStockBill> builder)
        {
            builder.ToTable("SupplierInStockBill");
            builder.HasKey(x => new { x.SupplierId, x.StockBillId });

            builder.HasOne(x => x.StockBill).WithMany(x => x.SupplierInStockBills).HasForeignKey(x => x.StockBillId);
            builder.HasOne(x => x.Supplier).WithMany(x => x.SupplierInStockBills).HasForeignKey(x => x.SupplierId);
        }
    }
}
