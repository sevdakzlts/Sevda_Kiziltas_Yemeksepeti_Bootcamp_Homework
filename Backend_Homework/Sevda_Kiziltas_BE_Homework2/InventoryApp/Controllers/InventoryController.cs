using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using InventoryApp.Data;
using InventoryApp.Model;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using FluentValidation.Resources;
using InventoryApp.Validation;


namespace InventoryApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IDatabase _inventoryData;

        public InventoryController(IDatabase inventoryData)
        {
            _inventoryData = inventoryData;
        }

        [HttpGet]
        public ActionResult<List<InventoryItem>> Get()
        {
            return Ok(_inventoryData.InventoryItems.Where(InventoryItem => InventoryItem.IsDeleted != 1).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<InventoryItem> Get(int id)
        {
            var data = _inventoryData.InventoryItems.FirstOrDefault(c => c.Id == id);
            if (data != null)
            {
                return Ok(data);
            }

            return NoContent();
        }

        [HttpPut]
        public ActionResult Put(InventoryItem item)
        {
            var data = _inventoryData.InventoryItems.FirstOrDefault(c => c.Id == item.Id);
            if (data != null)
            {
                data.Name = item.Name;
                data.PeriodType = item.PeriodType;
                data.Price = item.Price;
                data.UsagePeriod = item.UsagePeriod;
            }
            else
            {
                data = new InventoryItem()
                {
                    Id = _inventoryData.InventoryItems.Count,
                    Price = item.Price, Name = item.Name, PeriodType = item.PeriodType,
                    UsagePeriod = item.UsagePeriod, RentPrice = item.RentPrice
                };
                _inventoryData.InventoryItems.Add(data);
            }

            return Ok(data);
        }

        [HttpPost]
        public ActionResult Post(InventoryItem item)
        {
            item.Id = _inventoryData.InventoryItems.Count;
            item.IsDeleted = 0;
            _inventoryData.InventoryItems.Add(item);
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public ActionResult<InventoryItem> Delete(int id)
        {
            var data = _inventoryData.InventoryItems.FirstOrDefault(c => c.Id == id && c.IsDeleted == 0);
            if (data != null)
            {
                data.IsDeleted = 1;
                return Ok();
            }

            return NoContent();
        }

        [HttpPost("search")]
        [StringLengthValidator(3)]
        public ActionResult Search(SearchModel searchModel)
        {
            List<string> validations = new List<string>();
            if (searchModel.name.Length <3)
            {
                validations.Add("minimum 3 character");
            }
            var models = _inventoryData.InventoryItems.Where(item =>
                item.Name.Contains(searchModel.name) || item.Name.Contains(searchModel.name));

            return Ok(models);

        }


        public class SearchModel
        {
            public string name { get; set; }
        }
    }
}
