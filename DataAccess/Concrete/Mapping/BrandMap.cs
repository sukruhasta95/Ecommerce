﻿using Core.DataAccess.Abstract.Mapping;
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
    public partial class BrandMap : AppEntityTypeConfiguration<Brand>, IMapping
    {
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable(nameof(Brand));
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name);
            builder.Property(t => t.UpdatedTime);
            builder.Property(t => t.Active);

        }
    }
}
