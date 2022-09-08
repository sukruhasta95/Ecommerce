using Core.DataAccess.Abstract.Mapping;
using Core.DataAccess.Concrete.Mapping;

using Entities.Concrete;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Mapping
{
    public partial class ProductMap : AppEntityTypeConfiguration<Product>, IMapping
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));
            builder.HasKey(t => t.Id);
            builder.HasIndex(t => t.CategoryId);
            builder.HasIndex(t => t.BrandId);
            builder.Property(t => t.Name);
            builder.Property(t => t.Price);
            builder.Property(t => t.UpdatedTime);
            builder.Property(t => t.UnitsInStock);
            builder.Property(t => t.Description);
            builder.Property(t => t.Active);

            builder.HasOne(t => t.Category).WithMany(t => t.products).HasForeignKey(t => t.CategoryId);
            builder.HasOne(t => t.Brand).WithMany(t => t.products).HasForeignKey(t => t.BrandId);
        }
    }
}
