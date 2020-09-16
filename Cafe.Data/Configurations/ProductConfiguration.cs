using Cafe.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cafe.Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Product");
            builder.Property(x => x.Name).IsRequired().IsUnicode();
            builder.Property(x => x.Price).HasDefaultValue(0);
            builder.Property(x => x.Description).IsUnicode();
            builder.Property(x => x.Quantity).HasDefaultValue(1);
        }
    }
}
