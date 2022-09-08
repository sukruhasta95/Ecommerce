using Business.Abstract;

using DataAccess.Abstract;

using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        private readonly ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void Add(Cart cart)
        {
            cart.CreatedTime = DateTime.Now;
            cart.UpdatedTime = DateTime.Now;
            _cartDal.Add(cart);
        }

        public void Delete(Cart cart)
        {
            _cartDal.Delete(cart);
        }

        public List<Cart> GetAll()
        {
            return _cartDal.GetList().ToList();
        }

        public Cart GetById(int Id)
        {
            return _cartDal.Get(x => x.Id == Id);
        }

        public void Update(Cart cart)
        {
            _cartDal.Update(cart);
        }
    }
}
