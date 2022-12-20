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
        void Add(Customer customer);
        Customer GetByMail(string email);
    }
}
