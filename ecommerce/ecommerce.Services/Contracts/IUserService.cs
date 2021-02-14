using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Users;

namespace ecommerce.Services.Contracts
{
    public interface IUserService
    {
        IQueryable<UserEntity> Get();
        UserEntity Get(Guid id);
        UserEntity GetByEmail(string email);
        UserEntity GetByToken(string token);
        Task<UserEntity> Create(CreateUserModel model);
        Task<UserEntity> Update(Guid id, UpdateUserModel model);
        Task Delete(Guid id);
    }
}
