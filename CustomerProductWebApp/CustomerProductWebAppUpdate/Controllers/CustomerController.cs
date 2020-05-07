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
    public class CustomerController : ControllerBase
    {

        public CustomerDomain customerDomain { get; set; }
        public CustomerController()
        {
            this.customerDomain = new CustomerDomain();
        }

        [HttpGet]
        public IActionResult Get()
        {

            var m = this.customerDomain.Get();
            return Ok(m);

        }
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            customerDomain.Add(customer);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Customer customer)
        {
            customerDomain.Update(customer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            customerDomain.Delete(id);
            return Ok();
        }

    }
}