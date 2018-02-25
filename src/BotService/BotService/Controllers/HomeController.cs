using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotService.Interface.Contracts;
using BotService.Interface.ServiceModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BotService.Controllers
{
    [Produces("application/json")]
    [Route("Home")]
    public class HomeController : Controller
    {
        private IBotService _botservice;
        public HomeController(IBotService botservice)
        {
            _botservice = botservice;
        }

        //// POST api/values
        [HttpPost]
        public Messages Post([FromBody]JObject value)
        {
           

            return _botservice.CallService(value);

            
        }
        //[HttpPost]
        //public JObject Post([FromBody]JObject value)
        //{
        //    return value;
        //}
    }
}