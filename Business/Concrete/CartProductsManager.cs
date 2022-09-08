using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CartProductsManager : ICartProductsService
    {
        private readonly ICartProductDal _cartProductDal;
        private readonly ICartDal _cartDal;
        private readonly IProductDal _productDal;

        public CartProductsManager(ICartProductDal cartProductDal,
            ICartDal cartDal,
            IProductDal productDal)
        {
            _cartProductDal = cartProductDal;
            _cartDal = cartDal;
            _productDal = productDal;
        }

        public void Add(CartProduct cartProduct)
        {
            var CartData = _cartDal.GetList(x => x.Id == cartProduct.CartId).FirstOrDefault();
            var ProductPrice = _productDal.GetList(x => x.Id == cartProduct.ProductId).Select(x=>x.Price).FirstOrDefault();
            CartData.TotalPrice += ProductPrice;

            _cartDal.Update(CartData);
            

            cartProduct.CreatedTime = DateTime.Now;
            cartProduct.UpdatedTime = DateTime.Now;

            _cartProductDal.Add(cartProduct);
        }
       
        public void Delete(CartProduct cartProduct)
        {
            var CartProductData = _cartProductDal.GetList(x => x.Id == cartProduct.Id).FirstOrDefault();
            var CartData = _cartDal.GetList(x => x.Id == CartProductData.CartId).FirstOrDefault();
            var Product = _productDal.GetList(x => x.Id == CartProductData.ProductId).FirstOrDefault();


            var ProductPrice = Product.Price;
            CartData.TotalPrice -= ProductPrice;

            _cartDal.Update(CartData);

            _cartProductDal.Delete(cartProduct);
        }

        public List<CartProduct> GetAll()
        {
            return _cartProductDal.GetList().ToList();
        }

        public CartProduct GetById(int Id)
        {
            return _cartProductDal.Get(x => x.Id == Id);
        }

        public void Update(CartProduct cartProduct)
        {
            _cartProductDal.Update(cartProduct);
        }
    }
}
