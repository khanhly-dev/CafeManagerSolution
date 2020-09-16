using Cafe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Configurations
{
    class StockBillConfiguration : IEntityTypeConfiguration<StockBill>
    {
        public void Configure(EntityTypeBuilder<StockBill> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("StockBill");
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.OriginalPrice).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired();
        }
    }
}
