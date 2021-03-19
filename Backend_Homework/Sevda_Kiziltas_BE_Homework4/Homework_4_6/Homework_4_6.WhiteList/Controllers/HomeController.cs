using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework_4_6.WhiteList.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Homework_4_6.WhiteList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(IpControlAttribute))]
    public class HomeController : ControllerBase
    {
        [HttpGet("[action]")]
        public IEnumerable<string> GetAllData()
        {
            return new List<string>
            {
                "Sevda",
                "User"
            };
        }

        [HttpGet("[action]")]
        public string GetData(string ip)
        {
            return "User";
        }
    }
}
