using ECommerceBackend.Core.Utilities.Results;
using ECommerceBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Business.Abstract
{
    public interface IOrderDetailService
    {
        IDataResult<OrderDetail> GetById(int orderDetailId);
        IDataResult<List<OrderDetail>> GetList();
        IResult Add(OrderDetail orderDetail);
        IResult Delete(OrderDetail orderDetail);
        IResult Update(OrderDetail orderDetail);
    }
}
