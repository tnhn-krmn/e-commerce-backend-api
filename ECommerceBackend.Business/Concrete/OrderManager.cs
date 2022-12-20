using ECommerceBackend.Business.Abstract;
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
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult("Sipariş eklendi");
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult("Sipariş silindi");
        }

        public IDataResult<Order> GetById(int orderId)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.OrderId == orderId));
        }

        public IDataResult<List<Order>> GetList()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList().ToList());
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult("Sipariş güncellendi");
        }
    }
}
