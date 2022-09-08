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
    public partial class CartMap: AppEntityTypeConfiguration<Cart>, IMapping
    {
        public override void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable(nameof(Cart));
            builder.HasKey(t => t.Id);
            builder.Property(t => t.UpdatedTime);
            builder.Property(t => t.Active);

          builder.HasOne(t=>t.Customer).WithOne(t=>t.Cart).HasForeignKey<Customer>("CustomerId");

        }
    }
}
