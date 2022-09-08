using Entities.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cart:BaseEntity,IEntity
    {
        public int CustomerId { get; set; }
        public ICollection<Product>products { get; set; }
        public virtual Customer Customer { get; set; }
        public double TotalPrice { get; set; }
        public ICollection<CartProduct> cartProducts { get; set; }
    }
}
