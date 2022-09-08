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
    public partial class CartProductMap : AppEntityTypeConfiguration<CartProduct>, IMapping
    {
        public override void Configure(EntityTypeBuilder<CartProduct> builder)
        {
            builder.ToTable(nameof(CartProduct));
            builder.HasKey(t => t.Id);          
            builder.Property(t => t.UpdatedTime);
            builder.Property(t => t.Active);

          

        }
    }
}
