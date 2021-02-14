using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecormmerce.Web.Models.Vehicles;

namespace ecommerce.Services.Contracts
{
    public interface IVehicleService
    {
        IQueryable<VehicleModel> Get();
        VehicleModel Get(Guid id);
        Task<VehicleModel> Create(CreateVehicleModel model);
        Task<VehicleModel> Update(Guid id, UpdateVehicleModel model);
    }
}
