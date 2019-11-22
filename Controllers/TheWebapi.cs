using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi_dotnet_core.Models;
using webapi_dotnet_core.Services;

namespace webapi_dotnet_core.Controllers
{
    [ApiController]
    [Route("v1")]
    public class firstWebapi : ControllerBase
    {
        private readonly IUserServices _services;

        public firstWebapi(IUserServices services)
        {
            _services = services;
        }

        [HttpGet]
        [Route("GetUser")]
        public ActionResult<Dictionary<string, User>> GetUser()
        {
            var userDictionary = _services.GetUser();

            if(userDictionary.Count == 0)
            {
                return NotFound();
            }

            return userDictionary;
        }

        [HttpPost]
        [Route("AddUser")]
        public ActionResult<User> AddUser(User users)
        {
            var userServices = _services.AddUser(users);

            if(users == null)
            {
                return NotFound();
            }

            return userServices;
        }

    }
}
