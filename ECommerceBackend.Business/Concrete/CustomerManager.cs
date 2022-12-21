using ECommerceBackend.Business.Abstract;
using ECommerceBackend.DataAccess.Abstract;
using ECommerceBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public Customer GetByMail(string email)
        {
            return _customerDal.Get(c => c.Email == email);
        }
    }
}
