using Cafe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Configurations
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Customer");
            builder.Property(x => x.Name).IsRequired().IsUnicode();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.Adress).IsUnicode();
        }
    }
}
