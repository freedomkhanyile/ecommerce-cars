using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Common.Exceptions;
using ecommerce.Data.Access.DAL;
using ecommerce.Data.Model.Entities;
using ecommerce.Services.Contracts;
using ecormmerce.Web.Models.Options;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services
{
    public class OptionService : IOptionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OptionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<OptionEntity> Get()
        {
            return GetQuery();
        }
        private IQueryable<OptionEntity> GetQuery()
        {
            return _unitOfWork.Query<OptionEntity>()
                .Include(o => o.Manufacturer);
        }
        public OptionEntity Get(int id)
        {
            var option = GetQuery().FirstOrDefault(o => o.Id == id);
            if (option == null)
                throw new NotFoundException("Option not found");
            return option;
        }


        public async Task<OptionEntity> Create(CreateOptionModel model)
        {
            if (GetQuery().Any(
                o => o.Code == model.Code.Trim() &&
                     o.Name == model.Name.Trim() &&
                     o.Value == model.Value
                ))
                throw new BadRequestException("This option combination already exists.");
            var option = new OptionEntity
            {
                Code = model.Code.Trim(),
                Name = model.Name.Trim(),
                Value = model.Value.Trim(),
                ManufacturerEntityId = model.ManufacturerEntityId,
                Price = model.Price,
                QtyStock = model.QtyStock,
                CreateUserId = model.CreateUserId,
                CreateDate = DateTime.UtcNow.ToLocalTime(),
                ModifyUserId = model.ModifyUserId,
                ModifyDate = DateTime.UtcNow.ToLocalTime(),
                StatusId = 1
            };

            _unitOfWork.Add(option);
            await _unitOfWork.CommitAsync();
            return option;
        }

        public async Task<OptionEntity> Update(int id, UpdateOptionModel model)
        {
            var option = Get(id);
            if(option == null)
                throw new NotFoundException($"Option with id {id} not found");
            option.Code = model.Code;
            option.Name = model.Name;
            option.Value = model.Value;
            option.ManufacturerEntityId = model.ManufacturerEntityId;
            option.Price = model.Price;
            option.QtyStock = model.QtyStock;
            option.ModifyUserId = model.ModifyUserId;
            option.StatusId = model.StatusId;
            await _unitOfWork.CommitAsync();
            return option;
        }
        
    }
}
