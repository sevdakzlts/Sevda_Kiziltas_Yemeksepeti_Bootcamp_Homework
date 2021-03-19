using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class PeriodTypeController : ControllerBase
    {
        public List<PeriodType> PeriodTypes = new List<PeriodType>();
        
        [HttpPost]
        public ActionResult Post(PeriodType newType)
        {
            if (PeriodTypes.Find(periodType => periodType.Id == newType.Id) != null)
            {
                return null; // eklenemedi
            }

            PeriodTypes.Add(newType);

            return Ok();
        }

        public ActionResult Get()
        {
            return Ok(PeriodTypes);
        }
    }
}
