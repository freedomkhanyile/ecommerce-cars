using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Api.AutoMapper;
using ecommerce.Services;
using ecommerce.Services.Contracts;

namespace ecommerce.Api.Controllers
{
    /// <summary>
    /// TODO: Implement option methods
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly IOptionService _optionService;
        private readonly IAutoMapper _mapper;

        public OptionsController(IOptionService optionService, IAutoMapper mapper)
        {
            _optionService = optionService;
            _mapper = mapper;
        }
    }
}
