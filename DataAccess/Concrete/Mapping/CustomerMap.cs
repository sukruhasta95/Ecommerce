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
    public partial class CustomerMap : AppEntityTypeConfiguration<Customer>, IMapping
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));
            builder.HasKey(t => t.Id);
            builder.Property(t => t.UpdatedTime);
            builder.Property(t => t.Active);
            builder.Property(t => t.FirstName);
            builder.Property(t => t.LastName);
            builder.Property(t => t.Address);
            builder.Property(t => t.PhoneNumber);

            builder.HasOne(t => t.Cart).WithOne(t => t.Customer).HasForeignKey<Cart>("CartId");

        }
    }
}
