using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static InventoryApp.Extensions.BuyOrRentExtension;

namespace InventoryApp.Model
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int UsagePeriod { get; set; }
        [Range(0,4,ErrorMessage = "Period types are 0 = daily, 1 = weekly, 2 = monthly, 3 = yearly")]
        public int PeriodType { get; set; } 
        public int IsDeleted { get; set; }
        public int RentPrice { get; set; }
        public string ShouldBuy => this.BuyOrRent();

    }
}
