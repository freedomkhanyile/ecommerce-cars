using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Common.Exceptions;
using ecommerce.Data.Access.DAL;
using ecommerce.Data.Model.Entities;
using ecommerce.Services.Contracts;
using ecormmerce.Web.Models.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<VehicleEntity> Get()
        {
            throw new NotImplementedException();
        }

        private IQueryable<VehicleEntity> GetQuery()
        {
            return _unitOfWork.Query<VehicleEntity>()
                .Include(v => v.Manufacturer);
        }
        public VehicleEntity Get(Guid id)
        {
            var vehicle = GetQuery().FirstOrDefault(v => v.Id == id);
            if (vehicle == null)
                throw new NotFoundException("Vehicle not found");
            return vehicle;
        }

        public async Task<VehicleEntity> Create(CreateVehicleModel model)
        {
            var vehicle = new VehicleEntity
            {
                ModelName = model.ModelName,
                ModelYear = model.ModelYear,
                BodyStyle = model.BodyStyle,
                ManufacturerEntityId = model.ManufacturerEntityId,
                CreateUserId = model.CreateUserId,
                CreateDate = DateTime.UtcNow.ToLocalTime(),
                ModifyUserId = model.ModifyUserId,
                ModifyDate = DateTime.UtcNow.ToLocalTime(),
                StatusId = 1
            };
            _unitOfWork.Add(vehicle);
            await _unitOfWork.CommitAsync();
            return vehicle;
        }

        public async Task<VehicleEntity> Update(Guid id, UpdateVehicleModel model)
        {
            var vehicle = Get(id);
            if (vehicle == null)
                throw new NotFoundException($"Vehicle not found");
            vehicle.ModelName = model.ModelName;
            vehicle.ModelYear = model.ModelYear;
            vehicle.BodyStyle = model.BodyStyle;
            vehicle.ManufacturerEntityId = model.ManufacturerEntityId;
            vehicle.ModifyUserId = model.ModifyUserId;
            vehicle.StatusId = model.StatusId;
            vehicle.ModifyDate = DateTime.UtcNow.ToLocalTime();
            await _unitOfWork.CommitAsync();
            return vehicle;
        }
        #region vehicle options 
        public List<VehicleOptionEntity> GetVehicleOptionsByVehicleId(Guid id)
        {
            return GetVehicleOptionsQuery().Where(v => v.VehicleEntityId == id).ToList();
        }
        private IQueryable<VehicleOptionEntity> GetVehicleOptionsQuery()
        {
            return _unitOfWork.Query<VehicleOptionEntity>()
                .Include(v => v.Vehicle);
        }

        public async Task<VehicleOptionEntity> CreateVehicleOption(CreateVehicleOptionModel model)
        {
            var vehicleOption = new VehicleOptionEntity
            {
                VehicleEntityId = model.VehicleEntityId,
                OptionEntityId = model.OptionEntityId,
                CreateUserId = model.CreateUserId,
                CreateDate = DateTime.UtcNow.ToLocalTime(),
                ModifyUserId = model.ModifyUserId,
                ModifyDate = DateTime.UtcNow.ToLocalTime(),
                StatusId = 1
            };

            _unitOfWork.Add(vehicleOption);
            await _unitOfWork.CommitAsync();
            return vehicleOption;
        }
        #endregion
    }
}
