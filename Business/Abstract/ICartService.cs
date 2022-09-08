using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService
    {
        List<Cart> GetAll();
        Cart GetById(int Id);
        void Add(Cart cart);
        void Update(Cart cart);
        void Delete(Cart cart);
    }
}
