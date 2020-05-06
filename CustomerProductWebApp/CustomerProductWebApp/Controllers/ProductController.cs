using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerProductWebApp.Domain;
using CustomerProductWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerProductWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public ProductDomain productDomain { get; set; }
        public ProductController()
        {
            this.productDomain = new ProductDomain();
        }

        [HttpGet]
        public IActionResult Get()
        {

            var m = this.productDomain.Get();
            return Ok(m);

        }
        [HttpPost]
        public IActionResult Post(Product product)
        {
            productDomain.Add(product);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Product product)
        {
            productDomain.Update(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            productDomain.Delete(id);
            return Ok();
        }

    }
}