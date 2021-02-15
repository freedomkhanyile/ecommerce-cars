using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Api.AutoMapper;
using ecommerce.Api.Filters;
using ecommerce.Services.Contracts;
using ecormmerce.Web.Models.Accounts;
using ecormmerce.Web.Models.Users;

namespace ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IAutoMapper _mapper;
        public AccountController(IAccountService accountService, IAutoMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        [ValidateModel]
        public UserWithTokenModel Login([FromBody] LoginModel model)
        {
            var result = _accountService.Authenticate(model.Email, model.Password);
            var resultModel = _mapper.Map<UserWithTokenModel>(result);
            return resultModel;
        }

        [HttpPost("Register")]
        [ValidateModel]
        public async Task<UserModel> Register([FromBody] RegisterModel model)
        {
            var result = await _accountService.Register(model);
            var resultModel = _mapper.Map<UserModel>(result);
            return resultModel;
        }


    }
}
