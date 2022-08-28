using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Order.BLL.Interfaces;
using Order.Client.Models;
using Order.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Order.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StateController : BaseController
    {
        private readonly IStateService _stateService;

        public StateController(IStateService stateService)
        {
            _stateService = stateService;
        }

        [HttpGet]
        public async Task<IEnumerable<StateUIModel>> Get(int? id)
        {
            try
            {
                return await _stateService.Get(id);
            }
            catch (Exception)
            {
                return new StateUIModel[] { };
            }
        }
    }
}
