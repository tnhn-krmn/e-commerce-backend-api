using ECommerceBackend.Core.DataAccess.EntityFramework;
using ECommerceBackend.DataAccess.Abstract;
using ECommerceBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepository<Product,Context>,IProductDal
    {
    }
}
