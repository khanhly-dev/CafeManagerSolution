using Cafe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Configurations
{
    public class ProductInSellBillConfiguration : IEntityTypeConfiguration<ProductInSellBill>
    {
        public void Configure(EntityTypeBuilder<ProductInSellBill> builder)
        {
            builder.ToTable("ProductInSellBill");
            builder.HasKey(x => new { x.SellBillId, x.ProductId });

            builder.HasOne(x => x.Product).WithMany(x => x.ProductInSellBills).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.SellBill).WithMany(x => x.ProductInSellBills).HasForeignKey(x => x.SellBillId);
        }
    }
}
