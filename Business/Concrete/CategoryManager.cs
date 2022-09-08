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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            category.CreatedTime = DateTime.Now;
            category.UpdatedTime = DateTime.Now;
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList().ToList();
        }

        public Category GetById(int Id)
        {
            return _categoryDal.Get(x => x.Id == Id);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
