using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Common.Exceptions;
using ecommerce.Data.Access.DAL;
using ecommerce.Data.Model.Entities;
using ecommerce.Services.Contracts;
using ecormmerce.Web.Models.Orders;
using ecormmerce.Web.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<OrderEntity> Get()
        {
            return GetQuery();
        }
        private IQueryable<OrderEntity> GetQuery()
        {
            return _unitOfWork.Query<OrderEntity>()
                .Include(o => o.Customer);
        }
        public OrderEntity Get(Guid id)
        {
            var order = GetQuery().FirstOrDefault(o => o.Id == id);
            if(order == null) 
                throw new NotFoundException($"Order with id: {id} not found");
            return order;
        }

        public async Task<OrderEntity> Create(CreateOrderModel model)
        {
            var order = new OrderEntity
            {
                Id = Guid.NewGuid(),
                Comments = model.Comments,
                Amount = model.Amount,
                CustomerEntityId = model.CustomerId,
                CreateUserId = model.CreateUserId,
                CreateDate = DateTime.UtcNow.ToLocalTime(),
                ModifyUserId = model.ModifyUserId,
                ModifyDate = DateTime.UtcNow.ToLocalTime(),
                StatusId = 1
            };
            _unitOfWork.Add(order);
            await _unitOfWork.CommitAsync();
            return order;
        }

        public Task<OrderEntity> Update(Guid id, UpdateOrderModel model)
        {
            var order = Get(id);
            if(order == null)
                throw new NotFoundException($"Order with id: {id} not found");
            order.Comments = model.Comments;
            order.Amount = model.Amount;
            order.CustomerEntityId = model.CustomerId;
            order.ModifyUserId = model.ModifyUserId;
            order.ModifyDate = DateTime.UtcNow.ToLocalTime();
        }
    }
}
