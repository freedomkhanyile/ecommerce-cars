using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Vehicles;

namespace ecommerce.Api.AutoMapper
{
    public class VehicleMapper: IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
           var map = configuration.CreateMap<VehicleEntity, VehicleModel>();
           map.ForMember(x => x.ManufacturerEntityId, x => x.MapFrom(m => m.Manufacturer.Id));
        }
    }
}
