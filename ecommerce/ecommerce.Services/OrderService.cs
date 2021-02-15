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
    /// <summary>
    /// TODO: Implement create order business logic
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVehicleService _vehicleService;
        private readonly IOptionService _optionService;

        public OrderService(IUnitOfWork unitOfWork, IVehicleService vehicleService, IOptionService optionService)
        {
            _unitOfWork = unitOfWork;
            _vehicleService = vehicleService;
            _optionService = optionService;
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
            if (order == null)
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


        public async Task<OrderEntity> Update(Guid id, UpdateOrderModel model)
        {
            var order = Get(id);
            if (order == null)
                throw new NotFoundException($"Order with id: {id} not found");
            order.Comments = model.Comments;
            order.Amount = model.Amount;
            order.CustomerEntityId = model.CustomerId;
            order.ModifyUserId = model.ModifyUserId;
            order.ModifyDate = DateTime.UtcNow.ToLocalTime();
            order.StatusId = model.StatusId;
            await _unitOfWork.CommitAsync();
            return order;
        }

        #region OrderLine logic

        public List<OrderLineEntity> GetOrderLinesByOrderId(Guid id)
        {
            return GetOrderLinesQuery().Where(x => x.OrderEntityId == id).ToList();
        }

        private IQueryable<OrderLineEntity> GetOrderLinesQuery()
        {
            return _unitOfWork.Query<OrderLineEntity>()
                .Include(o => o.Order);
        }
        public async Task<OrderLineEntity> CreateOrderLine(CreateOrderLineModel model)
        {
            var orderLine = new OrderLineEntity
            {
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                Amount = model.Amount,
                IsAssembling = model.IsAssembling,
                OrderEntityId = model.OrderEntityId,
                CreateUserId = model.CreateUserId,
                CreateDate = DateTime.UtcNow.ToLocalTime(),
                ModifyUserId = model.ModifyUserId,
                ModifyDate = DateTime.UtcNow.ToLocalTime(),
                StatusId = 1
            };

            _unitOfWork.Add(orderLine);
            await _unitOfWork.CommitAsync();
            return orderLine;
        }

        public async Task<OrderLineEntity> UpdateOrderLine(int id, UpdateOrderLineModel model)
        {
            var orderLine = GetOrderLinesQuery().FirstOrDefault(o => o.Id == id);
            if(orderLine == null)
                throw new NotFoundException($"Order line with Id : {id} not found");
            orderLine.ProductId = model.ProductId;
            orderLine.Quantity = model.Quantity;
            orderLine.IsAssembling = model.IsAssembling;
            orderLine.Amount = model.Amount;
            orderLine.ModifyUserId = model.ModifyUserId;
            orderLine.ModifyDate = DateTime.UtcNow.ToLocalTime();
            orderLine.StatusId = model.StatusId;
            await _unitOfWork.CommitAsync();
            return orderLine;
        }

        #endregion

    }
}
