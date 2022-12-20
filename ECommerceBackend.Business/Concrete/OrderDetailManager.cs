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
    public class OrderDetailManager : IOrderDetailService
    {
        private IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public IResult Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
            return new SuccessResult("Sipariş detay eklendi");
        }

        public IResult Delete(OrderDetail orderDetail)
        {
            _orderDetailDal.Delete(orderDetail);
            return new SuccessResult("Sipariş detay silindi");
        }

        public IDataResult<OrderDetail> GetById(int orderDetailId)
        {
            return new SuccessDataResult<OrderDetail>(_orderDetailDal.Get(o => o.OrderDetailId == orderDetailId));
        }

        public IDataResult<List<OrderDetail>> GetList()
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetailDal.GetList().ToList());
        }

        public IResult Update(OrderDetail orderDetail)
        {
            _orderDetailDal.Update(orderDetail);
            return new SuccessResult("Sipariş detay güncellendi");
        }
    }
}
