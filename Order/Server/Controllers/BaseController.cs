using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected ObjectResult Success(string message = default)
        {
            return Ok(new ResponseModel(true, message));
        }

        protected ObjectResult Error(string message = default)
        {
            return Ok(new ResponseModel(false, message));
        }
    }
}
