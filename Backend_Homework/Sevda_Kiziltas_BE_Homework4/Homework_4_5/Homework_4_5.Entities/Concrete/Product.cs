using System;
using System.Collections.Generic;
using System.Text;
using Homework_4_5.Core.Entities;


namespace Homework_4_5.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
