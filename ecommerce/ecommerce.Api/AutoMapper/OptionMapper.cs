using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Options;

namespace ecommerce.Api.AutoMapper
{
    public class OptionMapper: IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<OptionEntity, OptionModel>();
            map.ForMember(x => x.ManufacturerEntityId, x => x.MapFrom(m => m.Manufacturer.Id));
        }
    }
}
