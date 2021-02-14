using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Data.Access.constants;
using ecommerce.Data.Access.DAL;
using ecommerce.Data.Model.Entities;
using ecommerce.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Api.Security
{
    public class SecurityContext : ISecurityContext
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        private UserEntity _userEntity;
        public SecurityContext(IHttpContextAccessor contextAccessor, IUnitOfWork unitOfWork)
        {
            _contextAccessor = contextAccessor;
            _unitOfWork = unitOfWork;
            ;
        }
        public UserEntity UserEntity
        {
            get
            {
                if (_userEntity != null) return _userEntity;
                if (!_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
                    throw new UnauthorizedAccessException();

                var email = _contextAccessor.HttpContext.User.Identity.Name;

                _userEntity = _unitOfWork.Query<UserEntity>()
                    .Where(x => x.Email == email)
                    .Include(x => x.Roles)
                    .ThenInclude(x => x.Role)
                    .FirstOrDefault();

                if (_userEntity == null)
                    throw new UnauthorizedAccessException("userEntity not found");

                return _userEntity;
            }
        }
        public bool IsAdministrator { get { return UserEntity.Roles.Any(x => x.Role.RoleName == RoleConstants.Admin); } }
        public bool IsStaff { get { return UserEntity.Roles.Any(x => x.Role.RoleName == RoleConstants.Manufacturer); } }
        public bool IsCustomer { get { return UserEntity.Roles.Any(x => x.Role.RoleName == RoleConstants.Customer); } }
    }
}
