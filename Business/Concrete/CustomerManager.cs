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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            customer.CreatedTime = DateTime.Now;
            customer.UpdatedTime = DateTime.Now;
           
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetList().ToList();
        }

        public Customer GetById(int Id)
        {
            return _customerDal.Get(x => x.Id == Id);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
