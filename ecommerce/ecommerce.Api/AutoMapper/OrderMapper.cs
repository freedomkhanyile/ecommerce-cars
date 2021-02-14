using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Orders;

namespace ecommerce.Api.AutoMapper
{
    public class OrderMapper: IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<OrderEntity, OrderModel>();
            map.ForMember(x => x.CustomerEntityId, x => x.MapFrom(c => c.Customer.Id));
        }
    }
}
