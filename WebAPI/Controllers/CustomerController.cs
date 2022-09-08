using Business.Abstract;

using Entities.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet("getall")]


        public IActionResult GetList()
        {

            var result = _customerService.GetAll();
            return Ok(result);
        }


        [HttpGet("getbyid")]

        public IActionResult GetById(int customerId)
        {
            var result = _customerService.GetById(customerId);
            return Ok(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Customer customer)
        {
            _customerService.Add(customer);

            return Ok(customer);

        }

        [HttpPost("update")]

        public IActionResult Update(Customer customer)
        {
            _customerService.Update(customer);

            return Ok();
        }

        [HttpPost("delete")]

        public IActionResult Delete(Customer customer)
        {
            _customerService.Delete(customer);
            return Ok();
        }
    }
}
