using ECommerceBackend.Core.Utilities.Results;
using ECommerceBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
    }
}
