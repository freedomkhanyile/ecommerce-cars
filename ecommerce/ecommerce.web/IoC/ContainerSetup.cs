using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Data.Access.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ecommerce.web.IoC
{
    public static class ContainerSetup
    {
        public static void SetUp(IServiceCollection services, IConfiguration configuration)
        {
            AddUnitOfWork(services, configuration);
        }

        private static void AddUnitOfWork(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["Data:main"];
            services.AddDbContext<MainDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork>(uow => new EFUnitOfWork(uow.GetRequiredService<MainDbContext>()));
        }
    }
}
