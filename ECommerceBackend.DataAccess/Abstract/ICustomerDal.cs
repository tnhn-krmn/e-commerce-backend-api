using ECommerceBackend.Core.DataAccess;
using ECommerceBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        
    }
}
