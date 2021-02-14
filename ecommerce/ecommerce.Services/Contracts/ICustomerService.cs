using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Users;

namespace ecommerce.Services.Contracts
{
    public interface ICustomerService
    {
        IQueryable<CustomerEntity> Get();
        CustomerEntity Get(Guid id);
        Task<CustomerEntity> Create(CreateUserModel model);
        Task<CustomerEntity> Update(Guid id, UpdateUserModel model);
    }
}
