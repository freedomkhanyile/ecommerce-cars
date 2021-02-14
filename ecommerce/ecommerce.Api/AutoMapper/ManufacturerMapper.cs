using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Manufacturers;

namespace ecommerce.Api.AutoMapper
{
    public class ManufacturerMapper :IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<ManufacturerEntity, ManufacturerModel>();
        }
    }
}
