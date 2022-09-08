using Entities.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:BaseEntity,IEntity
    {
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set;}
        public virtual Brand Brand { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<CartProduct> cartProducts { get; set; }

    }
}
