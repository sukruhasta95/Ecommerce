﻿using Entities.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand:BaseEntity,IEntity
    {
        public ICollection<Product> products { get; set; }
        public string Name { get; set; }

    }
}
