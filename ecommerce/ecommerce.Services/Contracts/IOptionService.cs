using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecommerce.Data.Model.Entities;
using ecormmerce.Web.Models.Options;
using ecormmerce.Web.Models.Users;

namespace ecommerce.Services.Contracts
{
    public interface IOptionService
    {
        IQueryable<OptionEntity> Get();
        OptionEntity Get(int id);
        Task<OptionEntity> Create(CreateOptionModel model);
        Task<OptionEntity> Update(int id, UpdateOptionModel model);
    }
}
