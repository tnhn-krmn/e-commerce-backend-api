using ECommerceBackend.Core.Utilities.Results;
using ECommerceBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        Customer GetByMail(string email);
        IDataResult<List<Customer>> GetList();
    }
}
