using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryApp.Model;

namespace InventoryApp.Extensions
{
    public static class BuyOrRentExtension
    {
        public static string BuyOrRent(this InventoryItem item)
        {
            return item.RentPrice * item.PeriodType * item.UsagePeriod  >= item.Price ? "You should buy" : "You should rent";
        }
    }
}
