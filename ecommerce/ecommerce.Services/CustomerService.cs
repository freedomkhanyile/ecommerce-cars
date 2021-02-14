using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Common.Exceptions;
using ecommerce.Data.Access.DAL;
using ecommerce.Data.Model.Entities;
using ecommerce.Services.Contracts;
using ecormmerce.Web.Models.Customer;
using ecormmerce.Web.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<CustomerEntity> Get()
        {
            return GetQuery();
        }
        private IQueryable<CustomerEntity> GetQuery()
        {
            return _unitOfWork.Query<CustomerEntity>();
        }

        public CustomerEntity Get(Guid id)
        {
            var customer = GetQuery().FirstOrDefault(u => u.Id == id);
            if (customer == null)
                throw new NotFoundException("Customer not found");
            return customer;
        }

        public async Task<CustomerEntity> Create(CreateCustomerModel model)
        {
            if (GetQuery().Any(u => u.Email == model.Email.Trim()))
                throw new BadRequestException("Customer with this email address exists.");
            var customer = new CustomerEntity
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                Surname = model.Surname,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                City = model.City,
                AnnualIncome = model.AnnualIncome,
                CreateUserId = model.CreateUserId,
                CreateDate = DateTime.UtcNow.ToLocalTime(),
                ModifyUserId = model.ModifyUserId,
                ModifyDate = DateTime.UtcNow.ToLocalTime(),
                StatusId = 1
            };

            _unitOfWork.Add(customer);
            await _unitOfWork.CommitAsync();
            return customer;
        }

        public async Task<CustomerEntity> Update(Guid id, UpdateCustomerModel model)
        {
            var customer = GetQuery().FirstOrDefault(c => c.Id == id);
            if (customer == null)
                throw new NotFoundException("Customer not found");
            customer.FirstName = model.FirstName;
            customer.Surname = model.Surname;
            customer.PhoneNumber = model.PhoneNumber;
            customer.Address = model.Address;
            customer.City = model.City;
            customer.ModifyUserId = model.ModifyUserId;
            customer.ModifyDate = DateTime.UtcNow.ToLocalTime();

            await _unitOfWork.CommitAsync();
            return customer;
        }
    }
}
