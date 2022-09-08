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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            brand.CreatedTime = DateTime.Now;
            brand.UpdatedTime = DateTime.Now;         
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetList().ToList();
        }

        public Brand GetById(int Id)
        {
            return _brandDal.Get(x=>x.Id==Id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
