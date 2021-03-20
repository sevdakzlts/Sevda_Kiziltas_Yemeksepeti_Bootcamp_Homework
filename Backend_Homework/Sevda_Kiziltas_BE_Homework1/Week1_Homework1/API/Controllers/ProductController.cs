using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DummyData _dummyData;
       
        public ProductController(DummyData dummyData)
        {
            _dummyData = dummyData;
        }
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            return Ok(_dummyData.Products.Where(product => product.IsDeleted != 1));
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _dummyData.Products.FirstOrDefault(product1 => product1.Id == id && product1.IsDeleted == 0);
            if (product != null)
            {
                return Ok(product);
            }

            return NoContent();
        }

        [HttpPut]
        public ActionResult Put(Product data)
        {
            var product = _dummyData.Products.FirstOrDefault(product1 => product1.Id == data.Id);
           
            if (product != null)
            {
                product.Name = data.Name;
                product.Price = data.Price;
            }
            else
            {
                product = new Product() { Id = _dummyData.Products.Count, Price = data.Price, Name = data.Name };
                _dummyData.Products.Add(product);
            }


            return Ok(product);
        }

        [HttpPost]
        public ActionResult Post(Product data)
        {
            //_dummyData.Products.Sort(product => product.I); GUID
            data.Id = _dummyData.Products.Count;
            data.IsDeleted =0;

            return Ok(data);
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            var product = _dummyData.Products.FirstOrDefault(product1 => product1.Id == id && product1.IsDeleted == 0);
            if (product != null)
            {
                product.IsDeleted = 1;
                return Ok();
            }

            return NoContent();
        }

        [HttpOptions]
        public ActionResult Options()
        {
            this.Response.Headers.Add("Allow", "GET,OPTIONS,PUT,DELETE,POST");
            return Ok();
        }
    }
}
