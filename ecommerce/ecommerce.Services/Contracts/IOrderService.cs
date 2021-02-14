using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Orders;
using ecormmerce.Web.Models.Users;

namespace ecommerce.Services.Contracts
{
    public interface IOrderService
    {
        IQueryable<OrderEntity> Get();
        OrderEntity Get(Guid id);
        Task<OrderEntity> Create(CreateOrderModel model);
        Task<OrderEntity> Update(Guid id, UpdateOrderModel model);
        List<OrderLineEntity> GetOrderLinesByOrderId(Guid id);
        Task<OrderLineEntity> CreateOrderLine(CreateOrderLineModel model);
        Task<OrderLineEntity> UpdateOrderLine(int id, UpdateOrderLineModel model);
    }
}
