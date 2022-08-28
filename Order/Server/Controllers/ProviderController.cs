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
    public class ProviderController : BaseController
    {
        private readonly IProviderService _providerService;

        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProviderUIModel>> Get(int? id)
        {
            try
            {
                return await _providerService.Get(id);
            }
            catch (Exception)
            {
                return new ProviderUIModel[] { };
            }
        }

        [HttpPut]
        //TODO async ,await
        public ObjectResult Put([FromBody]string model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var providerModel = JsonConvert.DeserializeObject<ProviderUIModel>(model);

                    _providerService.Update(providerModel);
                }
                else
                 Error("Validation Error");

            }
            catch(Exception e) 
            {
                Error(e.Message);
            }

            return Success();
        }

        [HttpPost]
        //TODO async ,await
        public ObjectResult Post([FromBody]string model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var providerModel = JsonConvert.DeserializeObject<ProviderUIModel>(model);
                    _providerService.Add(providerModel);
                }
                else
                  Error("Validation Error");

            }
            catch (Exception e)
            {
                Error(e.Message);
            }

            return Success();
        }


        [HttpDelete]
        //TODO async ,await
        public ObjectResult Delete(int id)
        {
            try
            {
                _providerService.Remove(id);

            }
            catch (Exception e)
            {
                Error(e.Message);
            }

            return Success();
        }
    }
}
