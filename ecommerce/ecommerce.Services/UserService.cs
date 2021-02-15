using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Data.Access.DAL;
using ecommerce.Common.Exceptions;
using ecommerce.Data.Model.Entities;
using ecommerce.Services.Contracts;
using ecormmerce.Web.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<UserEntity> Get()
        {
            return GetQuery();
        }
        private IQueryable<UserEntity> GetQuery()
        {
            return _unitOfWork.Query<UserEntity>()
                .Include(r => r.Roles)
                .ThenInclude(x => x.Role);
        }

        public UserEntity Get(Guid id)
        {
            var user = GetQuery().FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new NotFoundException("UserEntity not found");
            return user;
        }

        public UserEntity GetByEmail(string email)
        {
            var user = GetQuery().FirstOrDefault(u => u.Email == email);
            if (user == null)
                throw new NotFoundException("User not found");
            return user;
        }

        public UserEntity GetByToken(string token)
        {
            var user = GetQuery().FirstOrDefault(u => u.UserToken == token);
            if (user == null)
                throw new NotFoundException("UserEntity not found");
            return user;
        }

        public async Task<UserEntity> Create(CreateUserModel model)
        {
            if (GetQuery().Any(u => u.Email == model.Email.Trim()))
                throw new BadRequestException("This email address is already in use.");

            var user = new UserEntity
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                Surname = model.Surname,
                Email = model.Email.Trim(),
                PhoneNumber = model.PhoneNumber,
                Password = model.Password,
                ManufacturerEntityId = Guid.Parse(model.ManufaturerId),
                CreateUserId = model.CreateUserId,
                CreateDate = DateTime.UtcNow.ToLocalTime(),
                ModifyUserId = model.ModifyUserId,
                ModifyDate = DateTime.UtcNow.ToLocalTime(),
                StatusId = 1
            };

            _unitOfWork.Add(user);
            AddUserRoles(user, model.Roles);
            await _unitOfWork.CommitAsync();
            return user;
        }

        public async Task<UserEntity> Update(Guid id, UpdateUserModel model)
        {
            var user = GetQuery().FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new NotFoundException("User not found");
            user.FirstName = model.FirstName;
            user.Surname = model.Surname;
            user.PhoneNumber = model.PhoneNumber;
            user.ModifyUserId = model.ModifyUserId;
            user.StatusId = model.StatusId;
            user.ModifyDate = DateTime.UtcNow.ToLocalTime();
            AddUserRoles(user, model.Roles);
            await _unitOfWork.CommitAsync();
            return user;
        }

     
        #region Private UserEntity Methods
        private void AddUserRoles(UserEntity userEntity, string[] RoleNames)
        {
            userEntity.Roles.Clear();
            foreach (var roleName in RoleNames)
            {
                var role = _unitOfWork.Query<RoleEntity>().FirstOrDefault(x => x.RoleName == roleName);
                if (role == null)
                {
                    throw new NotFoundException($"Role - {roleName} is not found");
                }
                userEntity.Roles.Add(new UserRoleEntity
                {
                    UserEntity = userEntity,
                    Role = role,
                    CreateUserId = "system",
                    CreateDate = DateTime.UtcNow.ToLocalTime(),
                    ModifyUserId = "system",
                    ModifyDate = DateTime.UtcNow.ToLocalTime(),
                    StatusId = 1
                });
            }
        }

        #endregion
    }
}
