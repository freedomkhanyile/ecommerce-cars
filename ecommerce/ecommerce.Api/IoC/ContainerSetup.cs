using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ecommerce.Api.AutoMapper;
using ecommerce.Api.Security;
using ecommerce.Data.Access.DAL;
using ecommerce.Security;
using ecommerce.Security.Auth;
using ecommerce.Security.Contracts;
using ecommerce.Services;
using ecommerce.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ecommerce.Api.IoC
{
    public class ContainerSetup
    {
        public static void SetUp(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureAuth(services);
            AddUnitOfWork(services, configuration);
            ConfigureAutoMapper(services);
            ConfigureCors(services);
            AddServices(services);
        }
        private static void ConfigureAuth(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ITokenBuilder, TokenBuilder>();
            services.AddScoped<ISecurityContext, SecurityContext>();
        }
        private static void AddUnitOfWork(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["Data:main"];
            services.AddDbContext<MainDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork>(uow => new EFUnitOfWork(uow.GetRequiredService<MainDbContext>()));
        }
        private static void ConfigureAutoMapper(IServiceCollection services)
        {
            var mappingConfig = AutoMapperConfigurator.Configure();
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(x => mapper);
            services.AddTransient<IAutoMapper, AutoMapperAdapter>();
        }
        public static void ConfigureCors(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });
        }

        public static void AddServices(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IOptionService, OptionService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IVehicleService, VehicleService>();
        }

    }
}
