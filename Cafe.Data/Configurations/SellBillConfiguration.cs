using Cafe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Configurations
{
    class SellBillConfiguration : IEntityTypeConfiguration<SellBill>
    {
        public void Configure(EntityTypeBuilder<SellBill> builder)
        {
            builder.ToTable("SellBill");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OriginalPrice).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.UserCreated).IsRequired();
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.Discout).IsRequired();

            builder.HasOne(x => x.Customer).WithMany(x => x.Bills).HasForeignKey(x => x.CustomerId);
        }
    }
}
