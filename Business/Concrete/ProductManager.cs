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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            product.CreatedTime = DateTime.Now;
            product.UpdatedTime = DateTime.Now;
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList().ToList();
        }

        public List<Product> GetByCategory(int CategoryId)
        {
            return _productDal.GetList(x => x.Id == CategoryId).ToList();
        }

        public Product GetById(int Id)
        {
            return _productDal.Get(x => x.Id == Id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
