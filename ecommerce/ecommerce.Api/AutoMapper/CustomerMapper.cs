using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Customer;

namespace ecommerce.Api.AutoMapper
{
    public class CustomerMapper: IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<CustomerEntity, CustomerModel>();
        }
    }
}
