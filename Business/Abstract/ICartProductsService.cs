using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartProductsService
    {
        List<CartProduct> GetAll();
        CartProduct GetById(int Id);
        void Add(CartProduct cartProduct);
        void Update(CartProduct cartProduct);
        void Delete(CartProduct cartProduct);
    }
}
