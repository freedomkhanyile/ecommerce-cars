using System;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Customer;

namespace ecommerce.Services.Contracts
{
    public interface ICustomerService
    {
        IQueryable<CustomerEntity> Get();
        CustomerEntity Get(Guid id);
        Task<CustomerEntity> Create(CreateCustomerModel model);
        Task<CustomerEntity> Update(Guid id, UpdateCustomerModel model);
    }
}
