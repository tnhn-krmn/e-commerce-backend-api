using ECommerceBackend.Business.Abstract;
using ECommerceBackend.Business.Constants;
using ECommerceBackend.Core.Utilities.Results;
using ECommerceBackend.DataAccess.Abstract;
using ECommerceBackend.DataAccess.Concrete.EntityFramework;
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

        public IDataResult<List<Customer>> GetList()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList());
        }

        public IResult Add(Customer customer)
        {
            if (customer.Name.Length == 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public Customer GetByMail(string email)
        {
            return _customerDal.Get(c => c.Email == email);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
