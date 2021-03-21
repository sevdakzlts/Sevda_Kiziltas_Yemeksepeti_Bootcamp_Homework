using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotels.API.Abstract;

namespace Hotels.API.Models.Derived
{
    public class Room : Resource
    {
        public string Name { get; set; }
        public int Rate { get; set; }
    }
}
