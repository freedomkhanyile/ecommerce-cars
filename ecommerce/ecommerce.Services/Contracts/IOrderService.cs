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
        Task<OrderEntity> Create(CreateUserModel model);
        Task<OrderEntity> Update(Guid id, UpdateOrderModel model);
    }
}
