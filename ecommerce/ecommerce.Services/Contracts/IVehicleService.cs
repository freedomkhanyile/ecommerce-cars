using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Vehicles;

namespace ecommerce.Services.Contracts
{
    public interface IVehicleService
    {
        IQueryable<VehicleEntity> Get();
        VehicleEntity Get(Guid id);
        Task<VehicleEntity> Create(CreateVehicleModel model);
        Task<VehicleEntity> Update(Guid id, UpdateVehicleModel model);
    }
}
