using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotels.API.Abstract;

namespace Hotels.API.Models.Derived
{
    public class HotelInfo : Resource
    {
        public string Title { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public HotelAddress Location { get; set; }
    }
}
