using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Common.Exceptions;
using ecommerce.Data.Access.DAL;
using ecommerce.Data.Access.Helpers;
using ecommerce.Data.Model.Entities;
using ecommerce.Security;
using ecommerce.Security.Auth;
using ecommerce.Security.Contracts;
using ecommerce.Services.Contracts;
using ecommerce.Services.Models;
using ecormmerce.Web.Models.Accounts;
using ecormmerce.Web.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITokenBuilder _tokenBuilder;
        private readonly IUserService _userService;
        private readonly ISecurityContext _securityContext;

        public AccountService(IUnitOfWork unitOfWork, ITokenBuilder tokenBuilder, IUserService userService, ISecurityContext securityContext)
        {
            _unitOfWork = unitOfWork;
            _tokenBuilder = tokenBuilder;
            _userService = userService;
            _securityContext = securityContext;
        }
        public UserWithToken Authenticate(string email, string password)
        {
            var user = (from u in _unitOfWork.Query<UserEntity>()
                        where u.Email == email
                        select u)
                .Include(r => r.Roles)
                .ThenInclude(r => r.Role)
                .FirstOrDefault();
            if (user == null)
                throw new BadRequestException("email/password not valid!");
            if (string.IsNullOrEmpty(password) || !user.Password.VerifyWithBCrypt(password))
                throw new BadRequestException("email/password not valid!");
            var expiryPeriod = DateTime.Now.ToLocalTime() + TokenAuthOption.ExpiresSpan;
            var token = _tokenBuilder.Build(user.Email, user.Roles.Select(r => r.Role.RoleName).ToArray(), expiryPeriod);
            return new UserWithToken
            {
                ExpiresAt = expiryPeriod,
                Token = token,
                User = user
            };
        }

        public UserEntity GetUserByEmailToken(string email)
        {
            var user = _userService.GetByEmail(email);
            user.UserToken = Guid.NewGuid().ToString();
            return user;
        }

        public UserWithToken GetUserByToken(string token)
        {
            var user = _userService.GetByToken(token);
            // log this user in so that we can change the password or by bypass the login process on activation.

            var expiryPeriod = DateTime.Now.ToLocalTime() + TokenAuthOption.ExpiresSpan;
            var genToken = _tokenBuilder.Build(user.Email, user.Roles.Select(r => r.Role.RoleName).ToArray(),
                expiryPeriod);

            return new UserWithToken
            {
                ExpiresAt = expiryPeriod,
                Token = genToken,
                User = user
            };
        }

        public async Task<UserEntity> Register(RegisterModel model)
        {
            var registerModel = new CreateUserModel
            {
                FirstName = model.FirstName,
                Surname = model.Surname,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                Password = model.Password.WithBCrypt(),
                Roles = model.Roles,
                ManufaturerId = model.ManufaturerId,
                CreateUserId = model.CreateUserId,
                ModifyUserId = model.ModifyUserId
            };
            var user = await _userService.Create(registerModel);
            return user;
        }
    }
}
