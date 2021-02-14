using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Orders;

namespace ecommerce.Api.AutoMapper
{
    public class OrderLineMapper: IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<OrderLineEntity, OrderLineModel>();
            map.ForMember(x => x.OrderEntityId, x => x.MapFrom(o => o.Order.Id));
        }
    }
}
