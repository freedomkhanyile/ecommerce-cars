using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Data.Model.Entities;
using ecommerce.Services.Models;
using ecormmerce.Web.Models.Accounts;

namespace ecommerce.Services.Contracts
{
    public interface IAccountService
    {
        UserWithToken Authenticate(string email, string password);
        UserEntity GetUserByEmailToken(string email);
        UserWithToken GetUserByToken(string token);
        Task<UserEntity> Register(RegisterModel model);
    }
}
