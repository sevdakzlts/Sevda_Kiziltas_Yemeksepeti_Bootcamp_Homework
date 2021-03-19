using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Homework_4_6.WhiteList.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Homework_4_6.WhiteList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        
        [HttpGet("[action]")]
        public IEnumerable<string> GetAllData()
        {
            return new List<string>
            {
                "Sevda",
                "Premium"
            };
        }

        [HttpGet("[action]")]
        public string GetData()
        {
            return "User";
        }
    }
}
