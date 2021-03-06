﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;

namespace ecommerce.Api.AutoMapper
{
    public class AutoMapperConfigurator
    {
        private static readonly object Lock = new object();
        private static MapperConfiguration _configuration;

        public static MapperConfiguration Configure()
        {
            lock (Lock)
            {
                if (_configuration != null) return _configuration;

                var thisType = typeof(AutoMapperConfigurator);

                var configInterfaceType = typeof(IAutoMapperTypeConfigurator);
                var configurators = thisType.GetTypeInfo().Assembly.GetTypes()
                    .Where(x => !string.IsNullOrWhiteSpace(x.Namespace))
                    .Where(y => y.Namespace.Contains(thisType.Namespace))
                    .Where(z => z.GetTypeInfo().GetInterface(configInterfaceType.Name) != null)
                    .Select(x => (IAutoMapperTypeConfigurator)Activator.CreateInstance(x))
                    .ToArray();

                void AggregatedConfigurator(IMapperConfigurationExpression config)
                {
                    foreach (var configurator in configurators)
                    {
                        configurator.Configure(config);
                    }
                }

                _configuration = new MapperConfiguration(AggregatedConfigurator);
                return _configuration;
            }
        }
    }
}
