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
    public class CustomerController
    {

        [HttpGet("[action]")]
        public IEnumerable<string> GetAllData()
        {
            return new List<string>
            {
                "Sevda",
                "Customer"
            };
        }

        [HttpGet("[action]")]
        public string GetData()
        {
            return "User";
        }
    }
}
