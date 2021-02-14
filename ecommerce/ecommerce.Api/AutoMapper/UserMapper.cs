using System.Linq;
using AutoMapper;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Users;

namespace ecommerce.Api.AutoMapper
{
    public class UserMapper : IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            var map = configuration.CreateMap<UserEntity, UserModel>();
            map.ForMember(x => x.Roles,
                x => x.MapFrom(u => u.Roles
                    .Select(r => r.Role.RoleName)
                    .ToArray()));

        }
    }
}
